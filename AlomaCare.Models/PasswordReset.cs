using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCare.Models;

public sealed class PasswordReset
{
    [Key]
    public Guid PasswordResetId { get; set; }

    [Required]
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; }

    [Required, StringLength(6)]
    public string Code { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime ExpiresAtUtc { get; set; }

    [Required]
    public bool IsUsed { get; set; } = false;
}
