using AlomaCare.Models;
using AlomaCare.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public interface IReportRepository
    {
        Task<ReportDTO> GetOutcomeReport(CategoryReportDTO dateListDTO);
        Task<ReportDTO> GetSepsisReport(CategoryReportDTO dateListDTO);
        Task<MortalityReportDTO> GetYearlyMortalityReport(int year);
    }
}
