using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class ParentalNutritionOption
    {
        [Key]
        public int ParentalNutritionOptionId { get; set; }
        public string ParentalNutritionName { get; set; }
    }
}
