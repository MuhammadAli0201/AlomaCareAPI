using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCareAPI.Models
{
    [Table("Antimicrobials")]
    public class Antimicrobial
    {
        [Key]
        public int AntimicrobialID { get; set; }

        [Required]
        [StringLength(100)]
        public string AntimicrobialName { get; set; }
    }
}
