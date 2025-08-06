using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        
        [StringLength(200)]
        public string? Description { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        // Navigation properties
        public virtual ICollection<Course>? Courses { get; set; }
        public virtual ICollection<Faculty>? Faculty { get; set; }
    }
}