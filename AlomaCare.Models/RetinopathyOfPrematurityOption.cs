using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class RetinopathyOfPrematurityOption
    {
        [Key]
        public int RetinopathyOfPrematurityOptionId { get; set; }
        public string RetinopathyOfPrematurityName { get; set; }
    }
}
