using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Services;
using SIMSWebApp.ViewModels;

namespace SIMSWebApp.Controllers
{
    public class FacultyController : Controller
    {
        private readonly FacultyService _facultyService;
        private readonly DepartmentService _departmentService;

        public FacultyController(FacultyService facultyService, DepartmentService departmentService)
        {
            _facultyService = facultyService;
            _departmentService = departmentService;
        }

        // GET: Faculty
        public async Task<IActionResult> Index()
        {
            var faculty = await _facultyService.GetAllFacultyAsync();
            return View(faculty);
        }

        // GET: Faculty/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var faculty = await _facultyService.GetFacultyByIdAsync(id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // GET: Faculty/Create
        public async Task<IActionResult> Create()
        {
            await PopulateDepartmentsDropDownList();
            return View();
        }

        // POST: Faculty/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FacultyCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var faculty = new Faculty
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Phone = model.Phone,
                    DepartmentID = model.DepartmentID
                };

                await _facultyService.CreateFacultyAsync(faculty, model.Username, model.Password);
                return RedirectToAction(nameof(Index));
            }

            await PopulateDepartmentsDropDownList(model.DepartmentID);
            return View(model);
        }

        // GET: Faculty/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var faculty = await _facultyService.GetFacultyByIdAsync(id);
            if (faculty == null)
            {
                return NotFound();
            }

            var model = new FacultyViewModel
            {
                FacultyID = faculty.FacultyID,
                FirstName = faculty.FirstName,
                LastName = faculty.LastName,
                Email = faculty.Email,
                Phone = faculty.Phone,
                DepartmentID = faculty.DepartmentID
            };

            await PopulateDepartmentsDropDownList(faculty.DepartmentID);
            return View(model);
        }

        // POST: Faculty/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FacultyViewModel model)
        {
            if (id != model.FacultyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var faculty = await _facultyService.GetFacultyByIdAsync(id);
                if (faculty == null)
                {
                    return NotFound();
                }

                faculty.FirstName = model.FirstName;
                faculty.LastName = model.LastName;
                faculty.Email = model.Email;
                faculty.Phone = model.Phone;
                faculty.DepartmentID = model.DepartmentID;

                await _facultyService.UpdateFacultyAsync(faculty);
                return RedirectToAction(nameof(Index));
            }

            await PopulateDepartmentsDropDownList(model.DepartmentID);
            return View(model);
        }

        // GET: Faculty/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var faculty = await _facultyService.GetFacultyByIdAsync(id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // POST: Faculty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _facultyService.DeleteFacultyAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDepartmentsDropDownList(int? selectedDepartmentId = null)
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            ViewBag.DepartmentID = new SelectList(departments, "DepartmentID", "Name", selectedDepartmentId);
        }
    }
}