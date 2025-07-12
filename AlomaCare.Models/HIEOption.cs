using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class HIEOption
    {
        [Key]
        public int HIEOptionId { get; set; }
        public string HIEOptionName { get; set; }
    }
}
