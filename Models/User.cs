using System.ComponentModel.DataAnnotations;

namespace AlomaCareAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Usernumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string ProfileImagePath { get; set; }
        public UserRole UserRole { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
