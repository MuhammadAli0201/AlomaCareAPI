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
        public async Task<ReportDTO> GetOutcomeReport(CategoryReportDTO categoryReportDTO)
        {
            List<ReportMonthDTO> reportMonthDTOs = [];
            List<DateTime> dates = GetDateRange(categoryReportDTO.Dates[0], categoryReportDTO.Dates[1]);
            Dictionary<string, double> categoryPercentMap = new Dictionary<string, double>();
            foreach (var date in dates)
            {
                var noOfCases = await context.Patients
                .Where(p => p.DateOfAdmission.Year == date.Year)
                .Where(p => p.DateOfAdmission.Month == date.Month)
                .CountAsync();
                var recordsQuery = context.Patients
                    .Where(p => p.DateOfAdmission.Year == date.Year)
                    .Where(p => p.DateOfAdmission.Month == date.Month);
                if (!string.IsNullOrEmpty(categoryReportDTO.Category))
                {
                    recordsQuery = recordsQuery.Where(r => r.OutcomeStatus == categoryReportDTO.Category);
                }
                var records = await recordsQuery
                    .GroupBy(p => p.OutcomeStatus)
                    .Select(g => new ReportRecordDTO
                    {
                        Admissions = noOfCases,
                        Cases = g.Count(),
                        Category = g.Key,
                        OutcomeRate = ((double)g.Count() / noOfCases) * 100.0
                    }).ToListAsync();
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
                ReportType = "Outcome",
                YearTotals = reportYearTotals.ToList()
            };

            return report;
        }

        public async Task<ReportDTO> GetSepsisReport(CategoryReportDTO categoryReportDTO)
        {
            List<ReportMonthDTO> reportMonthDTOs = [];
            List<DateTime> dates = GetDateRange(categoryReportDTO.Dates[0], categoryReportDTO.Dates[1]);
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
                        if (!string.IsNullOrEmpty(categoryReportDTO.Category) && organism?.OrganismName != categoryReportDTO.Category)
                            continue;
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
                    OutcomeRate = ((double)m.Value / noOfCases) * 100.0
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

        public async Task<MortalityReportDTO> GetYearlyMortalityReport(int year)
        {
            var monthsDates = Enumerable.Range(1, 12)
                .Select(month => new DateTime(year, month, 1))
                .ToList();
            List<MonthlyMortalityRecordDTO> monthlyRecords = [];
            foreach(var date in monthsDates)
            {
                var month = date.ToString("MMM yyyy").ToUpper();
                var currentMonthAdmissions = context.Patients
                    .Where(p => p.DateOfAdmission.Year == date.Year)
                    .Where(p => p.DateOfAdmission.Month == date.Month).Count();
                var monthlyRecord = await context.Patients
                    .Where(p => p.DateOfAdmission.Year == date.Year)
                    .Where(p => p.DateOfAdmission.Month == date.Month)
                    .Where(p => p.OutcomeStatus == "Died")
                    .GroupBy(p => p.OutcomeStatus == "Died")
                    .Select(g => new MonthlyMortalityRecordDTO
                    {
                        Admissions = currentMonthAdmissions,
                        Deaths = g.Count(),
                        Month = month,
                        MortalityRate = ((double)g.Count() / currentMonthAdmissions) * 100.0
                    }).FirstOrDefaultAsync();
                if(monthlyRecord != null)
                {
                    monthlyRecords.Add(monthlyRecord);
                }
                else
                {
                    monthlyRecords.Add(new MonthlyMortalityRecordDTO
                    {
                        Admissions = currentMonthAdmissions,
                        Deaths = 0,
                        Month = month,
                        MortalityRate = 0
                    });
                }
            }
            var totalAdmissions = monthlyRecords.Sum(m => m.Admissions);
            var totalDeaths = monthlyRecords.Sum(m => m.Deaths);
            var mortalityRate = totalAdmissions > 0 ? (double)totalDeaths / totalAdmissions : 0;
            var yearlyReport = new YearlyMortalityReportDTO
            {
                TotalAdmissions = totalAdmissions,
                TotalDeaths = totalDeaths,
                MortalityRate = mortalityRate * 100.0
            };

            var mortalityReport = new MortalityReportDTO
            {
                MonthlyRecords = monthlyRecords,
                YearlyReport = yearlyReport
            };

            return mortalityReport;
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
