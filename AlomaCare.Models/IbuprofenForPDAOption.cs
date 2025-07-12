using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class IbuprofenForPDAOption
    {
        [Key]
        public int IbuprofenForPDAOptionId { get; set; }
        public string IbuprofenForPDAName { get; set; }
    }
}
