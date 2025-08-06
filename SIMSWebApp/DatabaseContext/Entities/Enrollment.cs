using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public enum Grade
    {
        A, B, C, D, F, Incomplete, Withdrawn
    }

    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course? Course { get; set; }
        
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student? Student { get; set; }
        
        public Grade? Grade { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        
        [StringLength(500)]
        public string? Notes { get; set; }
    }
}