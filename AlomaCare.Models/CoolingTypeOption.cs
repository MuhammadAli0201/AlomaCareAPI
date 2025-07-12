using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class CoolingTypeOption
    {
        [Key]
        public int CoolingTypeOptionId { get; set; }
        public string CoolingTypeOptionName { get; set; }
    }
}
