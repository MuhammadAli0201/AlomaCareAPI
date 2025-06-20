using System.ComponentModel.DataAnnotations;

namespace AlomaCareAPI.Models
{
    
        public class Faq
        {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        [StringLength(400)]
        public string Answer { get; set; }
        }
    }

