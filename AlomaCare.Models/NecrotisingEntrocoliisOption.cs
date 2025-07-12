using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class NecrotisingEntrocoliisOption
    {
        [Key]
        public int NecrotisingEntrocoliisOptionId { get; set; }
        public string NecrotisingEntrocoliisName { get; set; }
    }
}
