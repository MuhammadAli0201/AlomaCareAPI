using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Province))]
        public int ProvinceId { get; set; }
        public Province? Province { get; set; }
        public List<Suburb> Suburbs { get; set; } = [];
    }
}
