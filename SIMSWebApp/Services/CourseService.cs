using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Services
{
    public class CourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public CourseService(ICourseRepository courseRepository, IDepartmentRepository departmentRepository)
        {
            _courseRepository = courseRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _courseRepository.GetAllCoursesAsync();
        }

        public async Task<int> GetCourseCountAsync()
        {
            var courses = await _courseRepository.GetAllCoursesAsync();
            return courses.Count();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _courseRepository.GetCourseByIdAsync(id);
        }

        public async Task<Course> GetCourseByCodeAsync(string courseCode)
        {
            return await _courseRepository.GetCourseByCodeAsync(courseCode);
        }

        public async Task<IEnumerable<Course>> GetCoursesByDepartmentAsync(int departmentId)
        {
            return await _courseRepository.GetCoursesByDepartmentAsync(departmentId);
        }

        public async Task<Course> CreateCourseAsync(Course course)
        {
            // Validate that the department exists
            if (course.DepartmentID.HasValue)
            {
                var department = await _departmentRepository.GetDepartmentByIdAsync(course.DepartmentID.Value);
                if (department == null)
                {
                    throw new ArgumentException("The specified department does not exist.");
                }
            }

            await _courseRepository.AddAsync(course);
            await _courseRepository.SaveChangesAsync();

            return course;
        }

        public async Task UpdateCourseAsync(Course course)
        {
            // Validate that the department exists if it's being updated
            if (course.DepartmentID.HasValue)
            {
                var department = await _departmentRepository.GetDepartmentByIdAsync(course.DepartmentID.Value);
                if (department == null)
                {
                    throw new ArgumentException("The specified department does not exist.");
                }
            }

            await _courseRepository.UpdateAsync(course);
            await _courseRepository.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(int id)
        {
            await _courseRepository.DeleteAsync(id);
            await _courseRepository.SaveChangesAsync();
        }
    }
}