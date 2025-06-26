using AlomaCareAPI.Context;
using AlomaCareAPI.DTOs;
using AlomaCareAPI.Helpers;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _authContext;
        public UserController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObject)
        {
            if (userObject == null)
                return BadRequest();

            var user = await _authContext.Users.Include(x => x.UserRole).FirstOrDefaultAsync(x => x.Usernumber == userObject.Usernumber);

            if (user == null)
                return NotFound(new { message = "User not found" });

            if (!PasswordHasher.VerifyPassword(userObject.Password, user.Password))
            {
                return BadRequest(new { Message = "Password is incorrect" });
            }

            if (user.UserRole.Approved is false || user.UserRole.Approved is null)
            {
                return BadRequest(new { Message = "Your account is not approved yet" });
            }

            // Generate JWT token
            user.Token = CreateJwt(user);

            return Ok(new
            {
                Token = user.Token,
                Role = user.Role,  // Return the role along with the token
                Message = "Login Success"
            });
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User userObject)
        {
            try
            {
                if (userObject == null)
                    return BadRequest();

                // Validate role
                if (string.IsNullOrEmpty(userObject.Role) ||
                    (userObject.Role != "Intern" && userObject.Role != "Admin" && userObject.Role != "Doctor"))
                {
                    return BadRequest(new { Message = "Please select a valid role: Intern, Admin, or Doctor" });
                }

                // Check if HPCSA# already exists
                if (await CheckUserNumberExistAsync(userObject.Usernumber))
                    return BadRequest(new { Message = "HPCSA number already exists" });

                // Check if email already exists
                if (await CheckEmailExistAsync(userObject.Email))
                    return BadRequest(new { Message = "The email already exists" });

                // Check password strength
                var pass = CheckPasswordStrength(userObject.Password);
                if (!string.IsNullOrEmpty(pass))
                    return BadRequest(new { Message = pass.ToString() });

                userObject.Password = PasswordHasher.Hashpassword(userObject.Password);
                // Role is already set from the request, no need to set default
                userObject.Token = "";

                var user = await _authContext.Users.AddAsync(userObject);


                await _authContext.SaveChangesAsync();

                var userRole = new UserRole
                {
                    UserRoleId = Guid.NewGuid(),
                    UserId = user.Entity.Id,
                    Approved = null
                };
                await _authContext.UserRoles.AddAsync(userRole);
                await _authContext.SaveChangesAsync();
                
                return Ok(new
                {
                    message = "User registered successfully"
                });
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }


        //chech if hpcsa# already exists method
        private async Task<bool> CheckUserNumberExistAsync(string usernumber)
        {
            return await _authContext.Users.AnyAsync(x => x.Usernumber == usernumber);
        }

        //chech if email already exists method
        private async Task<bool> CheckEmailExistAsync(string email)
        {
            return await _authContext.Users.AnyAsync(x => x.Email == email);
        }

        //check password strength method
        private static string CheckPasswordStrength(string pass)
        {
            StringBuilder sb = new StringBuilder();
            if (pass.Length < 9)
                sb.Append("Minimum password length should be 8" + Environment.NewLine);
            if (!(Regex.IsMatch(pass, "[a-z]") && Regex.IsMatch(pass, "[A-Z]") && Regex.IsMatch(pass, "[0-9]")))
                sb.Append("Password should be AlphaNumeric" + Environment.NewLine);
            if (!Regex.IsMatch(pass, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
                sb.Append("Password should contain special charcter" + Environment.NewLine);
            return sb.ToString();
        }

        //generate jwt token method that passes user, that fetches user role and usernumber, config in program.cs
        private string CreateJwt(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("veryverysceretkeythatislongenoughforhmacsha256algorithm"); //use a secure key
            var identity = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.NameIdentifier, user.Usernumber),
                new Claim(ClaimTypes.Sid, user.Id.ToString())
            });

            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = credentials
            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }

        //method returns list of users that have registered, check swagger api/user
        //Get all the users method that sends a resource to angular only if user is authenticated by the api first
        //this ensures that the user information is only available to them, we create an api in angular for this.
        [Authorize]     //remove to show list in swagger
        [HttpGet]
        public async Task<ActionResult<User>> GetAllUsers()
        {
            return Ok(await _authContext.Users.ToListAsync());
        }




        //Method to view account 
        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var userNumber = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userNumber))
                return Unauthorized();

            var user = await _authContext.Users.FirstOrDefaultAsync(u => u.Usernumber == userNumber);

            if (user == null)
                return NotFound();

            return Ok(new
            {
                user.FirstName,
                user.LastName,
                user.Email,
                user.Usernumber,
                user.Role,

            });
        }

        [Authorize]
        [HttpGet("roles")]
        public async Task<IActionResult> GetUserRoles()
        {
            var result = await _authContext.UserRoles.Include(u => u.User).ToListAsync();
            return Ok(result);
        }

        [Authorize]
        [HttpPost("update-role")]
        public async Task<IActionResult> UpdateUserRole([FromBody] UserRole userRole)
        {
            if (userRole == null || userRole.UserId <= 0)
                return BadRequest(new { Message = "Invalid user role data" });
            var existingUserRole = await _authContext.UserRoles.FirstOrDefaultAsync(u => u.UserId == userRole.UserId);
            if (existingUserRole == null)
                return NotFound(new { Message = "User role not found" });
            existingUserRole.Approved = userRole.Approved;
            _authContext.Entry(existingUserRole).State = EntityState.Modified;
            await _authContext.SaveChangesAsync();
            return Ok(new { Message = "User role updated successfully" });
        }


        [HttpPost("send-otp")]
        public async Task<IActionResult> SendOtp([FromBody] OtpRequest request)
        {
            if (string.IsNullOrEmpty(request.Email))
                return BadRequest(new { Message = "Email is required" });

            var user = await _authContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
                return NotFound(new { Message = "User not found" });
             
            var otp = new Random().Next(100000, 999999).ToString();

            var passwordReset = new PasswordReset
            {
                PasswordResetId = Guid.NewGuid(),
                UserId = user.Id,
                Code = otp,
                CreatedAtUtc = DateTime.UtcNow,
                ExpiresAtUtc = DateTime.UtcNow.AddMinutes(10),
                IsUsed = false
            };

            await _authContext.PasswordResets.AddAsync(passwordReset);
            await _authContext.SaveChangesAsync();
             
            await SendEmailAsync(request.Email, "Your OTP Code", $"Your OTP code is: {otp}");

            return Ok(new { Message = "OTP sent to your email" });
        }

        [HttpPost("verify-otp")]
        public async Task<IActionResult> VerifyOtp([FromBody] OtpVerifyRequest request)
        {
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Code))
                return BadRequest(new { Message = "Email and code are required" });

            var user = await _authContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
                return NotFound(new { Message = "User not found" });
             
            var latestOtp = await _authContext.PasswordResets
                .Where(pr => pr.UserId == user.Id && !pr.IsUsed)
                .OrderByDescending(pr => pr.CreatedAtUtc)
                .FirstOrDefaultAsync();

            if (latestOtp == null || latestOtp.Code != request.Code)
                return BadRequest(new { Message = "Invalid or expired OTP" });

            if (latestOtp.ExpiresAtUtc < DateTime.UtcNow)
                return BadRequest(new { Message = "OTP has expired" });

            return Ok(new { Message = "OTP verified" });
        }

        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword([FromBody] PasswordUpdateRequest request)
        {
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Code) || string.IsNullOrEmpty(request.NewPassword))
                return BadRequest(new { Message = "Email, code, and new password are required" });

            var user = await _authContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
                return NotFound(new { Message = "User not found" });
             
            var latestOtp = await _authContext.PasswordResets
                .Where(pr => pr.UserId == user.Id && !pr.IsUsed)
                .OrderByDescending(pr => pr.CreatedAtUtc)
                .FirstOrDefaultAsync();

            if (latestOtp == null || latestOtp.Code != request.Code)
                return BadRequest(new { Message = "Invalid or expired OTP" });

            if (latestOtp.ExpiresAtUtc < DateTime.UtcNow)
                return BadRequest(new { Message = "OTP has expired" });

            user.Password = PasswordHasher.Hashpassword(request.NewPassword);
            latestOtp.IsUsed = true;

            _authContext.Users.Update(user);
            _authContext.PasswordResets.Update(latestOtp);
            await _authContext.SaveChangesAsync();

            return Ok(new { Message = "Password updated successfully" });
        }

        private async Task SendEmailAsync(string toEmail, string subject, string body)
        { 
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("aliawan0201@gmail.com", "krgmnjeaaevefugs"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("aliawan0201@gmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false,
                };
                mailMessage.To.Add(toEmail);

                await smtpClient.SendMailAsync(mailMessage);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
