using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCareAPI.Models
{
    [Table("SonarFindings")]
    public class SonarFinding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SonarFindingID { get; set; }

        [Required]
        [StringLength(100)]
        public string SonarFindingName { get; set; }
    }
}
