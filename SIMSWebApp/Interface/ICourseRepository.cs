using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.Interface
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Course> GetCourseByCodeAsync(string courseCode);
        Task<IEnumerable<Course>> GetCoursesByDepartmentAsync(int departmentId);
        Task AddAsync(Course course);
        Task UpdateAsync(Course course);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}