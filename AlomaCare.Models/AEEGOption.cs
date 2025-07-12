using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class AEEGOption
    {
        [Key]
        public int AEEGOptionId { get; set; }
        public string AEEGName { get; set; }
    }
}
