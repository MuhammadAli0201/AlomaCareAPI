using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class FreshFrozenPlasmaOption
    {
        [Key]
        public int FreshFrozenPlasmaOptionId { get; set; }
        public string FreshFrozenPlasmaName { get; set; }
    }
}
