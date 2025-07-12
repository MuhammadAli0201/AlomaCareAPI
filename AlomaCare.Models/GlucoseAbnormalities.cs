using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class GlucoseAbnormalities
    {
        [Key]
        public int GlucoseAbnormalitiesId { get; set; }
        public string GlucoseAbnormalitiesName { get; set; }
    }
}
