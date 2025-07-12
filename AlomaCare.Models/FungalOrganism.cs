using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCare.Models
{
    [Table("FungalOrganisms")]
    public class FungalOrganism
    {
        [Key]
        public int FungalOrganismID { get; set; }

        [Required]
        [StringLength(100)]
        public string FungalOrganismName { get; set; }
    }
}
