using Microsoft.EntityFrameworkCore;
using SIMSWebApp.DatabaseContext;
using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Repositories
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly SIMSDbContext _context;

        public ProgramRepository(SIMSDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Program>> GetAllProgramsAsync()
        {
            return await _context.Programs
                .Include(p => p.ProgramCourses)
                    .ThenInclude(pc => pc.Course)
                .ToListAsync();
        }

        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _context.Programs
                .Include(p => p.ProgramCourses)
                    .ThenInclude(pc => pc.Course)
                .FirstOrDefaultAsync(p => p.ProgramID == id);
        }

        public async Task<Program> GetProgramByNameAsync(string name)
        {
            return await _context.Programs
                .Include(p => p.ProgramCourses)
                    .ThenInclude(pc => pc.Course)
                .FirstOrDefaultAsync(p => p.Name == name);
        }

        public async Task AddAsync(Program program)
        {
            await _context.Programs.AddAsync(program);
        }

        public async Task UpdateAsync(Program program)
        {
            _context.Programs.Update(program);
        }

        public async Task DeleteAsync(int id)
        {
            var program = await _context.Programs.FindAsync(id);
            if (program != null)
            {
                _context.Programs.Remove(program);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}