using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class ROPFindingsOption
    {
        [Key]
        public int ROPFindingsOptionId { get; set; }
        public string ROPFindingsName { get; set; }
    }
}
