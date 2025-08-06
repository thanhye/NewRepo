using System.ComponentModel.DataAnnotations;

namespace SIMSWebApp.ViewModels
{
    public class DashboardViewModel
    {
        [Display(Name = "Total Students")]
        public int TotalStudents { get; set; }

        [Display(Name = "Total Courses")]
        public int TotalCourses { get; set; }

        [Display(Name = "Total Faculty")]
        public int TotalFaculty { get; set; }

        [Display(Name = "Total Departments")]
        public int TotalDepartments { get; set; }

        [Display(Name = "Total Enrollments")]
        public int TotalEnrollments { get; set; }

        [Display(Name = "Total Programs")]
        public int TotalPrograms { get; set; }
    }
}