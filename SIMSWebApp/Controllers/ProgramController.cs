using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Services;
using SIMSWebApp.ViewModels;

namespace SIMSWebApp.Controllers
{
    public class ProgramController : Controller
    {
        private readonly ProgramService _programService;
        private readonly CourseService _courseService;

        public ProgramController(ProgramService programService, CourseService courseService)
        {
            _programService = programService;
            _courseService = courseService;
        }

        // GET: Program
        public async Task<IActionResult> Index()
        {
            var programs = await _programService.GetAllProgramsAsync();
            return View(programs);
        }

        // GET: Program/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var program = await _programService.GetProgramByIdAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            var viewModel = new ProgramDetailsViewModel
            {
                ProgramID = program.ProgramID,
                Name = program.Name,
                Description = program.ProgramDescription,
                DurationInYears = program.DurationInYears,
                Courses = program.ProgramCourses?.Select(pc => new ProgramCourseViewModel
                {
                    CourseID = pc.CourseID,
                    CourseTitle = pc.Course?.Title,
                    CourseCode = pc.Course?.CourseCode,
                    Credits = pc.Course?.Credits ?? 0,
                    IsRequired = pc.IsRequired,
                    Year = pc.Year,
                    Semester = pc.Semester
                }).ToList() ?? new List<ProgramCourseViewModel>()
            };

            return View(viewModel);
        }

        // GET: Program/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Program/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProgramViewModel model)
        {
            if (ModelState.IsValid)
            {
                var program = new Program
                {
                    Name = model.Name,
                    Description = model.Description,
                    DurationInYears = model.DurationInYears
                };

                await _programService.CreateProgramAsync(program);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Program/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var program = await _programService.GetProgramByIdAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            var viewModel = new ProgramViewModel
            {
                ProgramID = program.ProgramID,
                Name = program.Name,
                Description = program.Description,
                DurationInYears = program.DurationInYears
            };

            return View(viewModel);
        }

        // POST: Program/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProgramViewModel model)
        {
            if (id != model.ProgramID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var program = await _programService.GetProgramByIdAsync(id);
                if (program == null)
                {
                    return NotFound();
                }

                program.Name = model.Name;
                program.Description = model.Description;
                program.DurationInYears = model.DurationInYears;

                await _programService.UpdateProgramAsync(program);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Program/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var program = await _programService.GetProgramByIdAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            return View(program);
        }

        // POST: Program/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _programService.DeleteProgramAsync(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Program/AddCourse/5
        public async Task<IActionResult> AddCourse(int id)
        {
            var program = await _programService.GetProgramByIdAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            var viewModel = new AddProgramCourseViewModel
            {
                ProgramID = id,
                ProgramName = program.Name
            };

            await PopulateCoursesDropDownList();
            return View(viewModel);
        }

        // POST: Program/AddCourse
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCourse(AddProgramCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var programCourse = new ProgramCourse
                {
                    ProgramID = model.ProgramID,
                    CourseID = model.CourseID,
                    IsRequired = model.IsRequired,
                    Year = model.Year,
                    Semester = model.Semester
                };

                await _programService.AddCourseToProgramAsync(programCourse);
                return RedirectToAction(nameof(Details), new { id = model.ProgramID });
            }

            var program = await _programService.GetProgramByIdAsync(model.ProgramID);
            if (program != null)
            {
                model.ProgramName = program.Name;
            }

            await PopulateCoursesDropDownList(model.CourseID);
            return View(model);
        }

        // GET: Program/RemoveCourse/5/10
        public async Task<IActionResult> RemoveCourse(int programId, int courseId)
        {
            await _programService.RemoveCourseFromProgramAsync(programId, courseId);
            return RedirectToAction(nameof(Details), new { id = programId });
        }

        private async Task PopulateCoursesDropDownList(int? selectedCourseId = null)
        {
            var courses = await _courseService.GetAllCoursesAsync();
            ViewBag.CourseID = new SelectList(courses, "CourseID", "Title", selectedCourseId);
        }
    }
}