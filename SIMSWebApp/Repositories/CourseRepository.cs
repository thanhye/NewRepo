using Microsoft.EntityFrameworkCore;
using SIMSWebApp.DatabaseContext;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SIMSDbContext _context;

        public CourseRepository(SIMSDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses
                .Include(c => c.Department)
                .ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _context.Courses
                .Include(c => c.Department)
                .FirstOrDefaultAsync(c => c.CourseID == id);
        }

        public async Task<Course> GetCourseByCodeAsync(string courseCode)
        {
            return await _context.Courses
                .Include(c => c.Department)
                .FirstOrDefaultAsync(c => c.CourseCode == courseCode);
        }

        public async Task<IEnumerable<Course>> GetCoursesByDepartmentAsync(int departmentId)
        {
            return await _context.Courses
                .Where(c => c.DepartmentID == departmentId)
                .ToListAsync();
        }

        public async Task AddAsync(Course course)
        {
            await _context.Courses.AddAsync(course);
        }

        public async Task UpdateAsync(Course course)
        {
            _context.Courses.Update(course);
        }

        public async Task DeleteAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}