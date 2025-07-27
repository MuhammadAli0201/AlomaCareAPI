using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCare.Models
{
    [Table("CongenitalInfectionOrganisms")]
    public class CongenitalInfectionOrganism
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CongenitalInfectionOrganismID { get; set; }

        [Required]
        [StringLength(100)]
        public string CongenitalInfectionOrganismName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
