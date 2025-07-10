using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCare.Models
{

    [Table("organisms")]
    public class Organism
    {
        [Key]
        public int OrganismID { get; set; }

        [Required]
        [StringLength(100)]
        public string OrganismName { get; set; }

        // Navigation properties
       // public virtual ICollection<DiagnosisOrganism> DiagnosisOrganisms { get; set; }
    }
}
