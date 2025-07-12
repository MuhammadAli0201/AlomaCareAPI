using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class PlateletTranfusionOption
    {
        [Key]
        public int PlateletTranfusionOptionId { get; set; }
        public string PlateletTranfusionName { get; set; }
    }
}
