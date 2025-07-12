using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class NeonatalJaundiceRequirementOption
    {
        [Key]
        public int NeonatalJaundiceRequirementOptionId { get; set; }
        public string NeonatalJaundiceRequirementName { get; set; }
    }
}
