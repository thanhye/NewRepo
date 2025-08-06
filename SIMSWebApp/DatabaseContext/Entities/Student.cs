using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        [StringLength(100)]
        public string? Address { get; set; }
        
        [StringLength(20)]
        public string? Phone { get; set; }
        
        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public virtual User? User { get; set; }
        
        // Navigation properties
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}