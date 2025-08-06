using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.Interface
{
    public interface IFacultyRepository
    {
        Task<IEnumerable<Faculty>> GetAllFacultyAsync();
        Task<Faculty> GetFacultyByIdAsync(int id);
        Task<Faculty> GetFacultyByUserIdAsync(int userId);
        Task<IEnumerable<Faculty>> GetFacultyByDepartmentAsync(int departmentId);
        Task AddAsync(Faculty faculty);
        Task UpdateAsync(Faculty faculty);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}