using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        
        [Required]
        [StringLength(10)]
        public string CourseCode { get; set; } = null!;
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public int Credits { get; set; }
        
        public int? DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
        
        // Navigation properties
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
        public virtual ICollection<CourseAssignment>? CourseAssignments { get; set; }
    }
}