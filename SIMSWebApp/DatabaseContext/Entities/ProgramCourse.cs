using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class ProgramCourse
    {
        [Key]
        public int ProgramCourseID { get; set; }
        
        [ForeignKey("Program")]
        public int ProgramID { get; set; }
        public virtual Program? Program { get; set; }
        
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course? Course { get; set; }
        
        public bool IsRequired { get; set; }
        
        public int Year { get; set; }
        
        public int Semester { get; set; }
    }
}