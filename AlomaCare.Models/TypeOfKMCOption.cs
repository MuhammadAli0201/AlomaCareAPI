using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class TypeOfKMCOption
    {
        [Key]
        public int TypeOfKMCOptionId { get; set; }
        public string TypeOfKMCName { get; set; }
    }
}
