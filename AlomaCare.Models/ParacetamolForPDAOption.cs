using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class ParacetamolForPDAOption
    {
        [Key]
        public int ParacetamolForPDAOptionId { get; set; }
        public string ParacetamolForPDAName { get; set; }
    }
}
