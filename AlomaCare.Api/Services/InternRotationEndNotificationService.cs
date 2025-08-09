
using System.Net.Mail;
using System.Net;
using AlomaCare.Context;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Api.Services
{
    public class InternRotationEndNotificationService : BackgroundService
    {
        private readonly IServiceScopeFactory scopeFactory;
        private readonly ILogger<InternRotationEndNotificationService> logger;

        public InternRotationEndNotificationService(IServiceScopeFactory scopeFactory,
            ILogger<InternRotationEndNotificationService> logger)
        {
            this.scopeFactory = scopeFactory;
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Logic to trigger emails to interns
                await SendEmailsTointerns(stoppingToken);
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }
        }

        private async Task SendEmailsTointerns(CancellationToken stoppingToken)
        {
            using var scope = scopeFactory.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            var remainingDays = 1;

            var targetDate = DateTime.UtcNow.Date.AddDays(remainingDays);
            var rotationEndingInterns = await dbContext.Users
                .Where(u => u.Role == "Intern")
                .Where(u => u.VerifiedDate.AddMonths(3) <= targetDate)
                .ToListAsync(stoppingToken);

            foreach(var intern in rotationEndingInterns)
            {
                await SendEmailAsync(intern.Email, "End of rotation notification ",
                    $"Dear {intern.FirstName} {intern.LastName},\nYour rotation is ending on {intern.VerifiedDate.AddMonths(3)}");
                Console.WriteLine($"Email is sent to {intern.Email} at {DateTime.UtcNow}");
            }
        }

        private async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("ameliachetty25@gmail.com", "bjzpksgoswmkagsf"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("ameliachetty25@gmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false,
                };
                mailMessage.To.Add(toEmail);

                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
