using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models.DTOs
{
    public class MonthlyMortalityRecordDTO
    {
        public string Month { get; set; }
        public int Admissions { get; set; }
        public int Deaths { get; set; }
        public double MortalityRate { get; set; }
    }
}
