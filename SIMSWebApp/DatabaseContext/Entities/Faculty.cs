using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        
        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }
        
        [StringLength(20)]
        public string? Phone { get; set; }
        
        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
        
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public virtual User? User { get; set; }
        
        // Navigation properties
        public virtual ICollection<CourseAssignment>? CourseAssignments { get; set; }
    }
}