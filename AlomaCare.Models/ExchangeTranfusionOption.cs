using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class ExchangeTranfusionOption
    {
        [Key]
        public int ExchangeTranfusionOptionId { get; set; }
        public string ExchangeTranfusionName { get; set; }
    }
}
