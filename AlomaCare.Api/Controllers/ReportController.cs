using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using AlomaCare.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportRepository repository;

        public ReportController(IReportRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost("outcome")]
        public async Task<ActionResult<ReportDTO>> GetOutcomeReport(CategoryReportDTO categoryReportDTO)
        {
            var response = await repository.GetOutcomeReport(categoryReportDTO);
            return Ok(response);
        }

        [HttpPost("sepsis")]
        public async Task<ActionResult<ReportDTO>> GetSepsisReport(CategoryReportDTO categoryReportDTO)
        {
            var response = await repository.GetSepsisReport(categoryReportDTO);
            return Ok(response);
        }

        [HttpGet("mortality/{year}")]
        public async Task<ActionResult<ReportDTO>> GetMortalityReport(int year)
        {
            var response = await repository.GetYearlyMortalityReport(year);
            return Ok(response);
        }
    }
}
