using System.ComponentModel.DataAnnotations;
using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.ViewModels
{
    public class EnrollmentCreateViewModel
    {
        [Required]
        [Display(Name = "Student")]
        public int StudentID { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int CourseID { get; set; }

        [Display(Name = "Notes")]
        [StringLength(500)]
        public string? Notes { get; set; }
    }

    public class EnrollmentEditViewModel
    {
        public int EnrollmentID { get; set; }

        [Display(Name = "Student")]
        public int StudentID { get; set; }

        [Display(Name = "Course")]
        public int CourseID { get; set; }

        [Display(Name = "Grade")]
        public Grade? Grade { get; set; }

        [Display(Name = "Notes")]
        [StringLength(500)]
        public string? Notes { get; set; }
    }

    public class EnrollmentDetailsViewModel
    {
        public int EnrollmentID { get; set; }

        [Display(Name = "Student")]
        public string StudentFullName { get; set; }

        [Display(Name = "Course")]
        public string CourseTitle { get; set; }

        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }

        [Display(Name = "Department")]
        public string DepartmentName { get; set; }

        [Display(Name = "Grade")]
        public Grade? Grade { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Notes")]
        public string? Notes { get; set; }
    }
}