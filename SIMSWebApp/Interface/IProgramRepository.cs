using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.Interface
{
    public interface IProgramRepository
    {
        Task<IEnumerable<Program>> GetAllProgramsAsync();
        Task<Program> GetProgramByIdAsync(int id);
        Task<Program> GetProgramByNameAsync(string name);
        Task AddAsync(Program program);
        Task UpdateAsync(Program program);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}