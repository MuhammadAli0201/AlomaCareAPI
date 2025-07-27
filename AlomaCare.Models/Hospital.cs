using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey(nameof(Province))]
        public int ProvinceId { get; set; }
        public Province? Province { get; set; }
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City? City { get; set; } = null;
        [ForeignKey(nameof(Suburb))]
        public int SuburbId { get; set; }
        public Suburb? Suburb { get; set; }
    }
}
