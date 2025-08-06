using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Services;
using SIMSWebApp.ViewModels;

namespace SIMSWebApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseService _courseService;
        private readonly DepartmentService _departmentService;

        public CourseController(CourseService courseService, DepartmentService departmentService)
        {
            _courseService = courseService;
            _departmentService = departmentService;
        }

        // GET: Course
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return View(courses);
        }

        // GET: Course/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public async Task<IActionResult> Create()
        {
            await PopulateDepartmentsDropDownList();
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var course = new Course
                {
                    CourseCode = model.CourseCode,
                    Title = model.Title,
                    Description = model.Description,
                    Credits = model.Credits,
                    DepartmentID = model.DepartmentID
                };

                await _courseService.CreateCourseAsync(course);
                return RedirectToAction(nameof(Index));
            }

            await PopulateDepartmentsDropDownList(model.DepartmentID);
            return View(model);
        }

        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            var model = new CourseViewModel
            {
                CourseID = course.CourseID,
                CourseCode = course.CourseCode,
                Title = course.Title,
                Description = course.Description,
                Credits = course.Credits,
                DepartmentID = course.DepartmentID
            };

            await PopulateDepartmentsDropDownList(course.DepartmentID);
            return View(model);
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CourseViewModel model)
        {
            if (id != model.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var course = await _courseService.GetCourseByIdAsync(id);
                if (course == null)
                {
                    return NotFound();
                }

                course.CourseCode = model.CourseCode;
                course.Title = model.Title;
                course.Description = model.Description;
                course.Credits = model.Credits;
                course.DepartmentID = model.DepartmentID;

                await _courseService.UpdateCourseAsync(course);
                return RedirectToAction(nameof(Index));
            }

            await PopulateDepartmentsDropDownList(model.DepartmentID);
            return View(model);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _courseService.DeleteCourseAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDepartmentsDropDownList(int? selectedDepartmentId = null)
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            ViewBag.DepartmentID = new SelectList(departments, "DepartmentID", "Name", selectedDepartmentId);
        }
    }
}
