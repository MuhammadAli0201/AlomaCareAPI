using AlomaCare.Context;
using AlomaCare.Models;
using AlomaCare.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlomaCare.Data.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly AppDbContext context;

        public ReportRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<ReportDTO> GetOutcomeReport(DateRangeDTO dateRangeDTO)
        {
            List<ReportMonthDTO> reportMonthDTOs = [];
            List<DateTime> dates = GetDateRange(dateRangeDTO.Dates[0], dateRangeDTO.Dates[1]);
            Dictionary<string, double> categoryPercentMap = new Dictionary<string, double>();
            foreach(var date in dates)
            {
                var noOfCases = await context.Patients
                .Where(p => p.DateOfAdmission.Year == date.Year)
                .Where(p => p.DateOfAdmission.Month == date.Month)
                .CountAsync();
                var records = await context.Patients
                    .Where(p => p.DateOfAdmission.Year == date.Year)
                    .Where(p => p.DateOfAdmission.Month == date.Month)
                    .GroupBy(p => p.OutcomeStatus)
                    .Select(g => new ReportRecordDTO
                    {
                        Admissions = noOfCases,
                        Cases = g.Count(),
                        Category = g.Key,
                        OutcomeRate = (double)g.Count() / noOfCases
                    }).ToListAsync();
                var currentCategoryMap = records.GroupBy(r => r.Category)
                    .ToDictionary(g => g.Key, g => (double)g.Sum(g => g.Cases));
                foreach(var kv in currentCategoryMap)
                {
                    if (categoryPercentMap.ContainsKey(kv.Key))
                    {
                        categoryPercentMap[kv.Key] += kv.Value;
                    }
                    else
                    {
                        categoryPercentMap.Add(kv.Key, kv.Value);
                    }
                }
                reportMonthDTOs.Add(new ReportMonthDTO { ReportMonthAndYear = date, ReportRecords = records });
            }

            foreach(var report1 in reportMonthDTOs)
            {
                var records = report1.ReportRecords;
                var sumOfCases = records.Sum(g => g.Cases);
                records.Add(new ReportRecordDTO { Cases = sumOfCases, Admissions = records.FirstOrDefault()?.Admissions ?? 0 });
            }

            var totalCases = categoryPercentMap.Values.Sum();
            var reportYearTotals = categoryPercentMap.Select(kvp => new ReportYearTotalsDTO
            {
                Category = kvp.Key,
                Percentage = totalCases == 0 ? 0 : Math.Round((double)(kvp.Value / totalCases) * 100, 2)
            });

            var report = new ReportDTO
            {
                MonthlyReports = reportMonthDTOs,
                ReportType = "Outcome",
                YearTotals = reportYearTotals.ToList()
            };

            return report;
        }

        public async Task<ReportDTO> GetSepsisReport(DateRangeDTO dateRangeDTO)
        {
            List<ReportMonthDTO> reportMonthDTOs = [];
            List<DateTime> dates = GetDateRange(dateRangeDTO.Dates[0], dateRangeDTO.Dates[1]);
            Dictionary<string, double> categoryPercentMap = new Dictionary<string, double>();
            foreach (var date in dates)
            {
                var noOfCases = await context.Patients
                .Where(p => p.DateOfAdmission.Year == date.Year)
                .Where(p => p.DateOfAdmission.Month == date.Month)
                .CountAsync();

                var diagnosisForms = await (from df in context.DiagnosisTreatmentForms
                    .Include(d=>d.NeonatalSepsis)
                    .Include(d => d.Patient)
                    .Where(d => d.Patient.DateOfAdmission.Year == date.Year)
                    .Where(d => d.Patient.DateOfAdmission.Month == date.Month)
                    select df).ToListAsync();
                Dictionary<string, int> monthCategoryPercentMap = new Dictionary<string, int>();
                foreach(var d in diagnosisForms)
                {
                    foreach (var organismId in d.NeonatalSepsis?.BsOrganism ?? [])
                    {
                        var organism = await context.Organisms.FindAsync(organismId);
                        if (monthCategoryPercentMap.ContainsKey(organism?.OrganismName ?? "") && organism != null)
                        {
                            monthCategoryPercentMap[organism?.OrganismName] += 1;
                        }
                        else if(organism != null)
                        {
                            monthCategoryPercentMap.Add(organism.OrganismName, 1);
                        }
                    }
                }

                var records = monthCategoryPercentMap.Select(m => new ReportRecordDTO
                {
                    Admissions = noOfCases,
                    Cases = m.Value,
                    Category = m.Key,
                    OutcomeRate = (double)m.Value / noOfCases
                }).ToList();

                var currentCategoryMap = records.GroupBy(r => r.Category)
                    .ToDictionary(g => g.Key, g => (double)g.Sum(g => g.Cases));
                foreach (var kv in currentCategoryMap)
                {
                    if (categoryPercentMap.ContainsKey(kv.Key))
                    {
                        categoryPercentMap[kv.Key] += kv.Value;
                    }
                    else
                    {
                        categoryPercentMap.Add(kv.Key, kv.Value);
                    }
                }
                reportMonthDTOs.Add(new ReportMonthDTO { ReportMonthAndYear = date, ReportRecords = records });
            }

            foreach (var report1 in reportMonthDTOs)
            {
                var records = report1.ReportRecords;
                var sumOfCases = records.Sum(g => g.Cases);
                records.Add(new ReportRecordDTO { Cases = sumOfCases, Admissions = records.FirstOrDefault()?.Admissions ?? 0 });
            }

            var totalCases = categoryPercentMap.Values.Sum();
            var reportYearTotals = categoryPercentMap.Select(kvp => new ReportYearTotalsDTO
            {
                Category = kvp.Key,
                Percentage = totalCases == 0 ? 0 : Math.Round((double)(kvp.Value / totalCases) * 100, 2)
            });

            var report = new ReportDTO
            {
                MonthlyReports = reportMonthDTOs,
                ReportType = "Sepsis",
                YearTotals = reportYearTotals.ToList()
            };

            return report;
        }

        private List<DateTime> GetDateRange(DateTime startDate, DateTime endDate)
        {
            var dates = new List<DateTime>();

            for (var date = startDate.Date; date <= endDate.Date; date = date.AddMonths(1))
            {
                dates.Add(date);
            }

            return dates;
        }
    }
}
