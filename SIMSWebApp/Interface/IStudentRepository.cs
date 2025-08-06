using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.Interface
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task<Student> GetStudentByUserIdAsync(int userId);
        Task<IEnumerable<Student>> GetStudentsByNameAsync(string firstName, string lastName);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}