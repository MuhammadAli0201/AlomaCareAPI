using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class Cardiovascular
    {
        [Key]
        public int CardiovascularId { get; set; }
        public string CardiovascularName { get; set; }
    }
}
