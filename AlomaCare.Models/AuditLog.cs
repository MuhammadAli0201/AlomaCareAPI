using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class AuditLog
    {
        [Key]
        public int AuditLogId { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public string ActionType { get; set; }
        public string EntityType { get; set; }
        public string Description { get; set; }
    }
}
