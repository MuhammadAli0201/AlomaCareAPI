using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class KangarooCareOption
    {
        [Key]
        public int KangarooCareOptionId { get; set; }
        public string KangarooCareName { get; set; }
    }
}
