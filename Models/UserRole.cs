using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlomaCareAPI.Models;

public sealed class UserRole
{ 
    public Guid UserRoleId { get; set; }
    [Required]
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
    public bool Approved { get; set; }
}
