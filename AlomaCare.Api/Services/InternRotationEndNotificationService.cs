
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
            }
        }
    }
}
