using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Services
{
    public class FacultyService
    {
        private readonly IFacultyRepository _facultyRepository;
        private readonly IUserRepository _userRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public FacultyService(IFacultyRepository facultyRepository, IUserRepository userRepository, IDepartmentRepository departmentRepository)
        {
            _facultyRepository = facultyRepository;
            _userRepository = userRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<Faculty>> GetAllFacultyAsync()
        {
            return await _facultyRepository.GetAllFacultyAsync();
        }

        public async Task<int> GetFacultyCountAsync()
        {
            var faculty = await _facultyRepository.GetAllFacultyAsync();
            return faculty.Count();
        }

        public async Task<Faculty> GetFacultyByIdAsync(int id)
        {
            return await _facultyRepository.GetFacultyByIdAsync(id);
        }

        public async Task<Faculty> GetFacultyByUserIdAsync(int userId)
        {
            return await _facultyRepository.GetFacultyByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Faculty>> GetFacultyByDepartmentAsync(int departmentId)
        {
            return await _facultyRepository.GetFacultyByDepartmentAsync(departmentId);
        }

        public async Task<Faculty> CreateFacultyAsync(Faculty faculty, string username, string password, string role = "Faculty")
        {
            // Validate that the department exists
            if (faculty.DepartmentID.HasValue)
            {
                var department = await _departmentRepository.GetDepartmentByIdAsync(faculty.DepartmentID.Value);
                if (department == null)
                {
                    throw new ArgumentException("The specified department does not exist.");
                }
            }

            // Create a new user account for the faculty member
            var user = new User
            {
                UserName = username,
                PasswordHash = password, // In a real application, this should be hashed
                Role = role,
                CreatedAt = DateTime.Now
            };

            await _userRepository.AddSync(user);
            await _userRepository.SaveChangeASync();

            // Associate the faculty with the user account
            faculty.UserID = user.UserID;

            await _facultyRepository.AddAsync(faculty);
            await _facultyRepository.SaveChangesAsync();

            return faculty;
        }

        public async Task UpdateFacultyAsync(Faculty faculty)
        {
            // Validate that the department exists if it's being updated
            if (faculty.DepartmentID.HasValue)
            {
                var department = await _departmentRepository.GetDepartmentByIdAsync(faculty.DepartmentID.Value);
                if (department == null)
                {
                    throw new ArgumentException("The specified department does not exist.");
                }
            }

            await _facultyRepository.UpdateAsync(faculty);
            await _facultyRepository.SaveChangesAsync();
        }

        public async Task DeleteFacultyAsync(int id)
        {
            await _facultyRepository.DeleteAsync(id);
            await _facultyRepository.SaveChangesAsync();
        }
    }
}