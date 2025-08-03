using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models.DTOs
{
    public class ReportRecordDTO
    {
        public string Category { get; set; }
        public int Cases { get; set; }
        public int Admissions { get; set; }
        public double OutcomeRate { get; set; }
    }
}
