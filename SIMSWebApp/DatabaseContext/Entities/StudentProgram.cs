using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class StudentProgram
    {
        [Key]
        public int StudentProgramID { get; set; }
        
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student? Student { get; set; }
        
        [ForeignKey("Program")]
        public int ProgramID { get; set; }
        public virtual Program? Program { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date)]
        public DateTime? ExpectedGraduationDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? ActualGraduationDate { get; set; }
        
        public string Status { get; set; } = "Active"; // Active, Graduated, Withdrawn, etc.
    }
}