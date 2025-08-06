using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = null!;
        
        [StringLength(1000)]
        public string? Message { get; set; }
        
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User? User { get; set; }
        
        public bool IsRead { get; set; } = false;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime? ReadAt { get; set; }
        
        [StringLength(50)]
        public string NotificationType { get; set; } = "General"; // General, Course, Grade, etc.
    }
}