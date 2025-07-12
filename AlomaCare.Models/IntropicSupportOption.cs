using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class IntropicSupportOption
    {
        [Key]
        public int IntropicSupportOptionId { get; set; }
        public string IntropicSupportName { get; set; }
    }
}
