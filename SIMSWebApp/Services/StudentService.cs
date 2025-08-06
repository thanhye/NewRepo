using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IUserRepository _userRepository;

        public StudentService(IStudentRepository studentRepository, IUserRepository userRepository)
        {
            _studentRepository = studentRepository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }

        public async Task<int> GetStudentCountAsync()
        {
            var students = await _studentRepository.GetAllStudentsAsync();
            return students.Count();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _studentRepository.GetStudentByIdAsync(id);
        }

        public async Task<Student> GetStudentByUserIdAsync(int userId)
        {
            return await _studentRepository.GetStudentByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Student>> SearchStudentsByNameAsync(string searchTerm)
        {
            // Split the search term to handle first and last name searches
            var terms = searchTerm.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = terms.Length > 0 ? terms[0] : string.Empty;
            string lastName = terms.Length > 1 ? terms[1] : string.Empty;

            return await _studentRepository.GetStudentsByNameAsync(firstName, lastName);
        }

        public async Task<Student> CreateStudentAsync(Student student, string username, string password, string role = "Student")
        {
            // Create a new user account for the student
            var user = new User
            {
                UserName = username,
                PasswordHash = password, // In a real application, this should be hashed
                Role = role,
                CreatedAt = DateTime.Now
            };

            await _userRepository.AddSync(user);
            await _userRepository.SaveChangeASync();

            // Associate the student with the user account
            student.UserID = user.UserID;
            student.EnrollmentDate = DateTime.Now;

            await _studentRepository.AddAsync(student);
            await _studentRepository.SaveChangesAsync();

            return student;
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
            await _studentRepository.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(int id)
        {
            await _studentRepository.DeleteAsync(id);
            await _studentRepository.SaveChangesAsync();
        }
    }
}