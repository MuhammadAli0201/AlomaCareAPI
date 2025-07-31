using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models.DTOs
{
    public class ReportDTO
    {
        public string ReportType { get; set; }
        public DateTime ReportMonthAndYear { get; set; }
        public List<ReportRecordDTO> ReportRecords { get; set; }
        public List<ReportYearTotalsDTO> YearTotals { get; set; }
    }
}
