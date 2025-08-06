using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Services;
using SIMSWebApp.ViewModels;

namespace SIMSWebApp.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly EnrollmentService _enrollmentService;
        private readonly StudentService _studentService;
        private readonly CourseService _courseService;

        public EnrollmentController(EnrollmentService enrollmentService, StudentService studentService, CourseService courseService)
        {
            _enrollmentService = enrollmentService;
            _studentService = studentService;
            _courseService = courseService;
        }

        // GET: Enrollment
        public async Task<IActionResult> Index()
        {
            var enrollments = await _enrollmentService.GetAllEnrollmentsAsync();
            return View(enrollments);
        }

        // GET: Enrollment/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        // GET: Enrollment/Create
        public async Task<IActionResult> Create()
        {
            await PopulateStudentsDropDownList();
            await PopulateCoursesDropDownList();
            await PopulateGradesDropDownList();
            return View();
        }

        // POST: Enrollment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EnrollmentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _enrollmentService.EnrollStudentInCourseAsync(model.StudentID, model.CourseID, model.Notes);
                    return RedirectToAction(nameof(Index));
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            await PopulateStudentsDropDownList(model.StudentID);
            await PopulateCoursesDropDownList(model.CourseID);
            await PopulateGradesDropDownList();
            return View(model);
        }

        // GET: Enrollment/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            var model = new EnrollmentEditViewModel
            {
                EnrollmentID = enrollment.EnrollmentID,
                StudentID = enrollment.StudentID,
                CourseID = enrollment.CourseID,
                Grade = enrollment.Grade,
                Notes = enrollment.Notes
            };

            await PopulateStudentsDropDownList(enrollment.StudentID);
            await PopulateCoursesDropDownList(enrollment.CourseID);
            await PopulateGradesDropDownList(enrollment.Grade);
            return View(model);
        }

        // POST: Enrollment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EnrollmentEditViewModel model)
        {
            if (id != model.EnrollmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);
                if (enrollment == null)
                {
                    return NotFound();
                }

                // Update grade
                await _enrollmentService.UpdateEnrollmentGradeAsync(id, model.Grade ?? Grade.F);
                
                // Update notes
                await _enrollmentService.UpdateEnrollmentNotesAsync(id, model.Notes);

                return RedirectToAction(nameof(Index));
            }

            await PopulateStudentsDropDownList(model.StudentID);
            await PopulateCoursesDropDownList(model.CourseID);
            await PopulateGradesDropDownList(model.Grade);
            return View(model);
        }

        // GET: Enrollment/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        // POST: Enrollment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _enrollmentService.DeleteEnrollmentAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateStudentsDropDownList(int? selectedStudentId = null)
        {
            var students = await _studentService.GetAllStudentsAsync();
            ViewBag.StudentID = new SelectList(students, "StudentID", "LastName", selectedStudentId);
        }

        private async Task PopulateCoursesDropDownList(int? selectedCourseId = null)
        {
            var courses = await _courseService.GetAllCoursesAsync();
            ViewBag.CourseID = new SelectList(courses, "CourseID", "Title", selectedCourseId);
        }

        private async Task PopulateGradesDropDownList(Grade? selectedGrade = null)
        {
            var grades = Enum.GetValues(typeof(Grade))
                             .Cast<Grade>()
                             .Select(g => new { ID = g, Name = g.ToString() });
            ViewBag.Grade = new SelectList(grades, "ID", "Name", selectedGrade);
        }
    }
}