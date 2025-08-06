using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Services
{
    public class EnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository, IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _enrollmentRepository = enrollmentRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync()
        {
            return await _enrollmentRepository.GetAllEnrollmentsAsync();
        }

        public async Task<int> GetEnrollmentCountAsync()
        {
            var enrollments = await _enrollmentRepository.GetAllEnrollmentsAsync();
            return enrollments.Count();
        }

        public async Task<Enrollment> GetEnrollmentByIdAsync(int id)
        {
            return await _enrollmentRepository.GetEnrollmentByIdAsync(id);
        }

        public async Task<IEnumerable<Enrollment>> GetEnrollmentsByStudentAsync(int studentId)
        {
            return await _enrollmentRepository.GetEnrollmentsByStudentAsync(studentId);
        }

        public async Task<IEnumerable<Enrollment>> GetEnrollmentsByCourseAsync(int courseId)
        {
            return await _enrollmentRepository.GetEnrollmentsByCourseAsync(courseId);
        }

        public async Task<Enrollment> GetEnrollmentByStudentAndCourseAsync(int studentId, int courseId)
        {
            return await _enrollmentRepository.GetEnrollmentByStudentAndCourseAsync(studentId, courseId);
        }

        public async Task<Enrollment> EnrollStudentInCourseAsync(int studentId, int courseId, string notes = null)
        {
            // Validate that the student exists
            var student = await _studentRepository.GetStudentByIdAsync(studentId);
            if (student == null)
            {
                throw new ArgumentException("The specified student does not exist.");
            }

            // Validate that the course exists
            var course = await _courseRepository.GetCourseByIdAsync(courseId);
            if (course == null)
            {
                throw new ArgumentException("The specified course does not exist.");
            }

            // Check if the student is already enrolled in the course
            var existingEnrollment = await _enrollmentRepository.GetEnrollmentByStudentAndCourseAsync(studentId, courseId);
            if (existingEnrollment != null)
            {
                throw new InvalidOperationException("The student is already enrolled in this course.");
            }

            // Create a new enrollment
            var enrollment = new Enrollment
            {
                StudentID = studentId,
                CourseID = courseId,
                EnrollmentDate = DateTime.Now,
                Notes = notes
            };

            await _enrollmentRepository.AddAsync(enrollment);
            await _enrollmentRepository.SaveChangesAsync();

            return enrollment;
        }

        public async Task UpdateEnrollmentGradeAsync(int enrollmentId, Grade grade)
        {
            var enrollment = await _enrollmentRepository.GetEnrollmentByIdAsync(enrollmentId);
            if (enrollment == null)
            {
                throw new ArgumentException("The specified enrollment does not exist.");
            }

            enrollment.Grade = grade;
            await _enrollmentRepository.UpdateAsync(enrollment);
            await _enrollmentRepository.SaveChangesAsync();
        }

        public async Task UpdateEnrollmentNotesAsync(int enrollmentId, string notes)
        {
            var enrollment = await _enrollmentRepository.GetEnrollmentByIdAsync(enrollmentId);
            if (enrollment == null)
            {
                throw new ArgumentException("The specified enrollment does not exist.");
            }

            enrollment.Notes = notes;
            await _enrollmentRepository.UpdateAsync(enrollment);
            await _enrollmentRepository.SaveChangesAsync();
        }

        public async Task DeleteEnrollmentAsync(int id)
        {
            await _enrollmentRepository.DeleteAsync(id);
            await _enrollmentRepository.SaveChangesAsync();
        }
    }
}