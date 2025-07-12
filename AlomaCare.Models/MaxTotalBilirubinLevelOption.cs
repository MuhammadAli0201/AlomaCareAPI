using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class MaxTotalBilirubinLevelOption
    {
        [Key]
        public int MaxTotalBilirubinLevelOptionId { get; set; }
        public string MaxTotalBilirubinLevelName { get; set; }
    }
}
