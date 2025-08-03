using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models.DTOs
{
    public class YearlyMortalityReportDTO
    {
        public int TotalAdmissions { get; set; }
        public int TotalDeaths { get; set; }
        public double MortalityRate { get; set; }
    }
}
