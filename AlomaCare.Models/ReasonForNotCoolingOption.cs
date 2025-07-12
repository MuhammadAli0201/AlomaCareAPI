using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class ReasonForNotCoolingOption
    {
        [Key]
        public int ReasonForNotCoolingOptionId { get; set; }
        public string ReasonForNotCoolingName { get; set; }
    }
}
