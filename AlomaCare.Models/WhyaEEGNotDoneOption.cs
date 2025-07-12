using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class WhyaEEGNotDoneOption
    {
        [Key]
        public int WhyaEEGNotDoneOptionId { get; set; }
        public string WhyaEEGNotDoneName { get; set; }
    }
}
