using SIMSWebApp.DatabaseContext.Entities;
using SIMSWebApp.Interface;

namespace SIMSWebApp.Services
{
    public class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _departmentRepository.GetAllDepartmentsAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _departmentRepository.GetDepartmentByIdAsync(id);
        }

        public async Task<Department> GetDepartmentByNameAsync(string name)
        {
            return await _departmentRepository.GetDepartmentByNameAsync(name);
        }

        public async Task<Department> CreateDepartmentAsync(Department department)
        {
            department.CreatedAt = DateTime.Now;
            await _departmentRepository.AddAsync(department);
            await _departmentRepository.SaveChangesAsync();

            return department;
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            await _departmentRepository.UpdateAsync(department);
            await _departmentRepository.SaveChangesAsync();
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            await _departmentRepository.DeleteAsync(id);
            await _departmentRepository.SaveChangesAsync();
        }
    }
}

public async Task<int> GetDepartmentCountAsync()
{
    var departments = await _departmentRepository.GetAllDepartmentsAsync();
    return departments.Count();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;
    await _departmentRepository.AddAsync(department);
    await _departmentRepository.SaveChangesAsync();

    return department;
}
{
    await _departmentRepository.UpdateAsync(department);
    await _departmentRepository.SaveChangesAsync();
}
{
    await _departmentRepository.DeleteAsync(id);
    await _departmentRepository.SaveChangesAsync();
}
{
    return await _departmentRepository.GetDepartmentByIdAsync(id);
}
{
    return await _departmentRepository.GetDepartmentByNameAsync(name);
}
{
    department.CreatedAt = DateTime.Now;