using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GraphsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("dashboard")]
        public IActionResult GetGraphDashboard()
        {
            var dashboard = new GraphDashboard();

            // -----------------------------
            // 1. Outcome Graph (Died/Survived)
            // -----------------------------
            var outcomeQuery = _context.Patients
                .GroupBy(p => p.OutcomeStatus)
                .Select(g => new { Label = g.Key, Count = g.Count() })
                .ToList();

            int outcomeTotal = outcomeQuery.Sum(x => x.Count);
            dashboard.Outcome = outcomeQuery.Select(x => new Graph
            {
                Label = x.Label,
                Count = x.Count,
                Percentage = outcomeTotal > 0 ? Math.Round((double)x.Count / outcomeTotal * 100, 2) : 0
            }).ToList();

            // -----------------------------
            // 2. Weight Graph (<1500g)
            // -----------------------------
            var lowWeight = _context.Patients.Count(p => p.BirthWeight < 1500);
            var normalWeight = _context.Patients.Count(p => p.BirthWeight >= 1500);
            var totalWeight = lowWeight + normalWeight;

            dashboard.Weight = new List<Graph>
            {
                new Graph
                {
                    Label = "< 1500g",
                    Count = lowWeight,
                    Percentage = totalWeight > 0 ? Math.Round((double)lowWeight / totalWeight * 100, 2) : 0
                },
                new Graph
                {
                    Label = "≥ 1500g",
                    Count = normalWeight,
                    Percentage = totalWeight > 0 ? Math.Round((double)normalWeight / totalWeight * 100, 2) : 0
                }
            };

            // -----------------------------
            // 3. Sepsis Graph
            // -----------------------------
            var YES = new Guid("28fe79ef-ab14-4c42-93fc-b702e62df2c3");

            // Step 2: Build the graph based on DiagnosisTreatmentForm → NeonatalSepsis
            var sepsisFlags = _context.DiagnosisTreatmentForms
                .Include(d => d.NeonatalSepsis)
                .Select(d => new
                {
                    Early = d.NeonatalSepsis.BacterialSepsisBeforeDay3 == YES ? 1 : 0,
                    Late = d.NeonatalSepsis.SepsisAfterDay3 == YES ? 1 : 0,
                    Fungal = d.NeonatalSepsis.FungalSepsis == YES ? 1 : 0
                })
                .ToList();

            int earlyCount = sepsisFlags.Sum(x => x.Early);
            int lateCount = sepsisFlags.Sum(x => x.Late);
            int fungalCount = sepsisFlags.Sum(x => x.Fungal);
            int totalSepsis = earlyCount + lateCount + fungalCount;

            // Step 3: Build the dashboard
            dashboard.Sepsis = new List<Graph>
{
    new Graph
    {
        Label = "Early Sepsis",
        Count = earlyCount,
        Percentage = totalSepsis > 0 ? Math.Round((double)earlyCount / totalSepsis * 100, 2) : 0
    },
    new Graph
    {
        Label = "Late Sepsis",
        Count = lateCount,
        Percentage = totalSepsis > 0 ? Math.Round((double)lateCount / totalSepsis * 100, 2) : 0
    },
    new Graph
    {
        Label = "Fungal Sepsis",
        Count = fungalCount,
        Percentage = totalSepsis > 0 ? Math.Round((double)fungalCount / totalSepsis * 100, 2) : 0
    }
}; var hieYesId = Guid.Parse("28FE79EF-AB14-4C42-93FC-B702E62DF2C3"); // HIE = Yes GUID

            // Fetch records with HIE = Yes including OtherNeonatalComplication
            var hieRecords = _context.DiagnosisTreatmentForms
                .Include(d => d.OtherNeonatalComplication)
                .Where(d => d.OtherNeonatalComplication != null &&
                            d.OtherNeonatalComplication.HieSection == hieYesId)
                .ToList();

            // Parse ThomsonScore strings to doubles
            var thomsonScores = hieRecords
                .Select(d => d.OtherNeonatalComplication.ThomsonScore)
                .Where(s => !string.IsNullOrEmpty(s))
                .Select(s =>
                {
                    bool parsed = double.TryParse(s, out double val);
                    return parsed ? (double?)val : null;
                })
                .Where(v => v.HasValue)
                .Select(v => v.Value)
                .ToList();

            // Parse BloodGasResult strings to doubles
            var bloodGasValues = hieRecords
                .Select(d => d.OtherNeonatalComplication.BloodGasResult)
                .Where(s => !string.IsNullOrEmpty(s))
                .Select(s =>
                {
                    bool parsed = double.TryParse(s, out double val);
                    return parsed ? (double?)val : null;
                })
                .Where(v => v.HasValue)
                .Select(v => v.Value)
                .ToList();

            // Calculate averages
            double avgThomson = thomsonScores.Any() ? thomsonScores.Average() : 0;
            double avgBloodGas = bloodGasValues.Any() ? bloodGasValues.Average() : 0;

            // Populate the graph (showing both averages)
            dashboard.HieGraph = new List<Graph>
{
    new Graph
    {
        Label = "Avg Thomson Score",
        Count = (int)Math.Round(avgThomson),
        Percentage = 0
    },
    new Graph
    {
        Label = "Avg Blood Gas Value",
        Count = (int)Math.Round(avgBloodGas),
        Percentage = 0
    }
};

            return Ok(dashboard);
        }
    }
}

