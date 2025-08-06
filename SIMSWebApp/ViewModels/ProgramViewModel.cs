using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.ViewModels
{
    public class ProgramViewModel
    {
        public int ProgramID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Program Name")]
        public string Name { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required]
        [Range(1, 10)]
        [Display(Name = "Duration (Years)")]
        public int DurationInYears { get; set; }
    }

    public class ProgramDetailsViewModel
    {
        public int ProgramID { get; set; }

        [Display(Name = "Program Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Duration (Years)")]
        public int DurationInYears { get; set; }

        public List<ProgramCourseViewModel> Courses { get; set; } = new List<ProgramCourseViewModel>();
    }

    public class ProgramCourseViewModel
    {
        public int CourseID { get; set; }

        [Display(Name = "Course Title")]
        public string CourseTitle { get; set; }

        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }

        [Display(Name = "Credits")]
        public int Credits { get; set; }

        [Display(Name = "Required")]
        public bool IsRequired { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "Semester")]
        public int Semester { get; set; }
    }

    public class AddProgramCourseViewModel
    {
        public int ProgramID { get; set; }

        [Display(Name = "Program")]
        public string ProgramName { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int CourseID { get; set; }

        [Required]
        [Display(Name = "Required Course")]
        public bool IsRequired { get; set; }

        [Required]
        [Range(1, 10)]
        [Display(Name = "Year")]
        public int Year { get; set; }

        [Required]
        [Range(1, 3)]
        [Display(Name = "Semester")]
        public int Semester { get; set; }
    }
}