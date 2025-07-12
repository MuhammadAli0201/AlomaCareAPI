using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class BloodTransfusionOption
    {
        [Key]
        public int BloodTransfusionOptionId { get; set; }
        public string BloodTransfusionName { get; set; }
    }
}
