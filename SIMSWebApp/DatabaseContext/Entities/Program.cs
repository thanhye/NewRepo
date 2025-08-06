using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.DatabaseContext.Entities
{
    public class Program
    {
        [Key]
        public int ProgramID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public int DurationInYears { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        // Navigation properties
        public virtual ICollection<ProgramCourse>? ProgramCourses { get; set; }
        public virtual ICollection<StudentProgram>? StudentPrograms { get; set; }
    }
}