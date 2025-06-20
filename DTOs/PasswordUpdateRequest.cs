namespace AlomaCareAPI.DTOs;

public class PasswordUpdateRequest
{
    public string Email { get; set; }
    public string Code { get; set; }
    public string NewPassword { get; set; }
}
