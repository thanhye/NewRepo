using Microsoft.EntityFrameworkCore;
using SIMSWebApp.DatabaseContext;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly SIMSDbContext _context;

        public FacultyRepository(SIMSDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Faculty>> GetAllFacultyAsync()
        {
            return await _context.Faculty
                .Include(f => f.Department)
                .Include(f => f.User)
                .ToListAsync();
        }

        public async Task<Faculty> GetFacultyByIdAsync(int id)
        {
            return await _context.Faculty
                .Include(f => f.Department)
                .Include(f => f.User)
                .FirstOrDefaultAsync(f => f.FacultyID == id);
        }

        public async Task<Faculty> GetFacultyByUserIdAsync(int userId)
        {
            return await _context.Faculty
                .Include(f => f.Department)
                .Include(f => f.User)
                .FirstOrDefaultAsync(f => f.UserID == userId);
        }

        public async Task<IEnumerable<Faculty>> GetFacultyByDepartmentAsync(int departmentId)
        {
            return await _context.Faculty
                .Include(f => f.User)
                .Where(f => f.DepartmentID == departmentId)
                .ToListAsync();
        }

        public async Task AddAsync(Faculty faculty)
        {
            await _context.Faculty.AddAsync(faculty);
        }

        public async Task UpdateAsync(Faculty faculty)
        {
            _context.Faculty.Update(faculty);
        }

        public async Task DeleteAsync(int id)
        {
            var faculty = await _context.Faculty.FindAsync(id);
            if (faculty != null)
            {
                _context.Faculty.Remove(faculty);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}