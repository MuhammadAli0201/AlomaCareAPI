using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class Metabolic
    {
        [Key]
        public int MetabolicId { get; set; }
        public string MetabolicName { get; set; }
    }
}
