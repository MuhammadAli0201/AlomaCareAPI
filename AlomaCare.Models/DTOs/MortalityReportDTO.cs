using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models.DTOs
{
    public class MortalityReportDTO
    {
        public List<MonthlyMortalityRecordDTO> MonthlyRecords { get; set; }
        public YearlyMortalityReportDTO YearlyReport { get; set; }
    }
}
