using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Services
{
    public class ProgramService
    {
        private readonly IProgramRepository _programRepository;

        public ProgramService(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        public async Task<IEnumerable<Program>> GetAllProgramsAsync()
        {
            return await _programRepository.GetAllProgramsAsync();
        }

        public async Task<int> GetProgramCountAsync()
        {
            var programs = await _programRepository.GetAllProgramsAsync();
            return programs.Count();
        }

        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _programRepository.GetProgramByIdAsync(id);
        }

        public async Task<Program> GetProgramByNameAsync(string name)
        {
            return await _programRepository.GetProgramByNameAsync(name);
        }

        public async Task<Program> CreateProgramAsync(Program program)
        {
            program.CreatedAt = DateTime.Now;
            await _programRepository.AddAsync(program);
            await _programRepository.SaveChangesAsync();

            return program;
        }

        public async Task UpdateProgramAsync(Program program)
        {
            await _programRepository.UpdateAsync(program);
            await _programRepository.SaveChangesAsync();
        }

        public async Task DeleteProgramAsync(int id)
        {
            await _programRepository.DeleteAsync(id);
            await _programRepository.SaveChangesAsync();
        }

        // Thêm phương thức mới
        public async Task AddCourseToProgramAsync(ProgramCourse programCourse)
        {
            var program = await _programRepository.GetProgramByIdAsync(programCourse.ProgramID);
            if (program == null)
            {
                throw new Exception("Program not found");
            }

            if (program.ProgramCourses == null)
            {
                program.ProgramCourses = new List<ProgramCourse>();
            }

            program.ProgramCourses.Add(programCourse);
            await _programRepository.UpdateAsync(program);
            await _programRepository.SaveChangesAsync();
        }

        // Thêm phương thức mới
        public async Task RemoveCourseFromProgramAsync(int programId, int courseId)
        {
            var program = await _programRepository.GetProgramByIdAsync(programId);
            if (program == null || program.ProgramCourses == null)
            {
                return;
            }

            var programCourse = program.ProgramCourses.FirstOrDefault(pc => pc.CourseID == courseId);
            if (programCourse != null)
            {
                program.ProgramCourses.Remove(programCourse);
                await _programRepository.UpdateAsync(program);
                await _programRepository.SaveChangesAsync();
            }
        }
    }
}