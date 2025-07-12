using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class OtherNeonatalComplicationGlucoseAbnormalities
    {
        [Key]
        public int OtherNeonatalComplicationId { get; set; }
        public int GlucoseAbnormalitiesId { get; set; }
    }
}
