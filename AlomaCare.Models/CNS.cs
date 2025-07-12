using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class CNS
    {
        [Key]
        public int CNSId { get; set; }
        public string CNSName { get; set; }
    }
}
