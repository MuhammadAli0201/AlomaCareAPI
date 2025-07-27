using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class Suburb
    {
        public int SuburbId { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City? City { get; set; }
        public List<Hospital> Hospitals { get; set; } = [];
    }
}
