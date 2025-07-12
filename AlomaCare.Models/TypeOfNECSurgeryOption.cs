using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class TypeOfNECSurgeryOption
    {
        [Key]
        public int TypeOfNECSurgeryOptionId { get; set; }
        public string TypeOfNECSurgeryName { get; set; }
    }
}
