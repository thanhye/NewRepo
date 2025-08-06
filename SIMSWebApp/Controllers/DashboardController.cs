using Microsoft.AspNetCore.Mvc;
using SIMSWebApp.Services;
using SIMSWebApp.ViewModels;
using System.Threading.Tasks;

namespace SIMSWebApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly StudentService _studentService;
        private readonly CourseService _courseService;
        private readonly FacultyService _facultyService;
        private readonly DepartmentService _departmentService;
        private readonly EnrollmentService _enrollmentService;
        private readonly ProgramService _programService;

        public DashboardController(
            StudentService studentService,
            CourseService courseService,
            FacultyService facultyService,
            DepartmentService departmentService,
            EnrollmentService enrollmentService,
            ProgramService programService)
        {
            _studentService = studentService;
            _courseService = courseService;
            _facultyService = facultyService;
            _departmentService = departmentService;
            _enrollmentService = enrollmentService;
            _programService = programService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new DashboardViewModel
            {
                TotalStudents = await _studentService.GetStudentCountAsync(),
                TotalCourses = await _courseService.GetCourseCountAsync(),
                TotalFaculty = await _facultyService.GetFacultyCountAsync(),
                TotalDepartments = await _departmentService.GetDepartmentCountAsync(),
                TotalEnrollments = await _enrollmentService.GetEnrollmentCountAsync(),
                TotalPrograms = await _programService.GetProgramCountAsync()
            };

            return View(viewModel);
        }
    }
}
