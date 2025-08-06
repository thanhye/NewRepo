using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.ViewModels
{
    public class DepartmentViewModel
    {
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [Display(Name = "Department Name")]
        [StringLength(50, ErrorMessage = "Department name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }

    public class DepartmentDetailsViewModel
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<CourseViewModel> Courses { get; set; }
        public IEnumerable<FacultyViewModel> Faculty { get; set; }
    }
}