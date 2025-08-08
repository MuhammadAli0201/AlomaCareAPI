using AlomaCare.Models;

namespace AlomaCare.Api.Helpers
{
    public static class AuditLogHelper
    {
        static public AuditLog GetPatientAuditLog(int userId, string actionType, string description = "")
        {
            return new AuditLog
            {
                ActionType = actionType,
                DateTime = DateTime.UtcNow,
                EntityType = "Patient",
                UserId = userId,
                Description = description
            };
        }

        static public AuditLog GetMaternalAuditLog(int userId, string actionType, string description = "")
        {
            return new AuditLog
            {
                ActionType = actionType,
                DateTime = DateTime.UtcNow,
                EntityType = "Maternal",
                UserId = userId,
                Description = description
            };
        }

        static public AuditLog GetDiagnosisAuditLog(int userId, string actionType, string description = "")
        {
            return new AuditLog
            {
                ActionType = actionType,
                DateTime = DateTime.UtcNow,
                EntityType = "Diagnosis",
                UserId = userId,
                Description = description
            };
        }
    }
}
