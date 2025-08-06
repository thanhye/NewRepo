using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class CourseAssignment
    {
        [Key]
        public int CourseAssignmentID { get; set; }
        
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course? Course { get; set; }
        
        [ForeignKey("Faculty")]
        public int FacultyID { get; set; }
        public virtual Faculty? Faculty { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime AssignmentDate { get; set; } = DateTime.Now;
        
        [StringLength(200)]
        public string? Notes { get; set; }
    }
}