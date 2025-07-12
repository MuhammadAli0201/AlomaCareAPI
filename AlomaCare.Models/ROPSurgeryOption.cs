using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class ROPSurgeryOption
    {
        [Key]
        public int ROPSurgeryOptionId { get; set; }
        public string ROPSurgeryName { get; set; }
    }
}
