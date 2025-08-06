using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.ViewModels
{
    public class CourseViewModel
    {
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Course code is required")]
        [Display(Name = "Course Code")]
        [StringLength(10, ErrorMessage = "Course code cannot be longer than 10 characters")]
        public string CourseCode { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Credits is required")]
        [Display(Name = "Credits")]
        [Range(1, 6, ErrorMessage = "Credits must be between 1 and 6")]
        public int Credits { get; set; }

        [Display(Name = "Department")]
        public int? DepartmentID { get; set; }

        public string DepartmentName { get; set; }
    }

    public class CourseDetailsViewModel
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public string DepartmentName { get; set; }
        public IEnumerable<EnrollmentViewModel> Enrollments { get; set; }
    }
}