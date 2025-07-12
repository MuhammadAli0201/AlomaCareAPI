using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class PDALitigationOption
    {
        [Key]
        public int PDALitigationOptionId { get; set; }
        public string PDALitigationName { get; set; }
    }
}
