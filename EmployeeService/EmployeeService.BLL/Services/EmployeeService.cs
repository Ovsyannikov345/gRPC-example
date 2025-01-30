using EmployeeService.BLL.Services.IServices;
using EmployeeService.DAL.Entities;
using EmployeeService.DAL.Repositories.IRepositories;

namespace EmployeeService.BLL.Services;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public async Task<Employee> CreateEmployeeAsync(Employee employee, CancellationToken cancellationToken = default)
    {
        return await employeeRepository.CreateAsync(employee, cancellationToken);
    }

    public async Task<Employee> GetEmployeeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await employeeRepository.GetByIdAsync(id, cancellationToken);
    }

    public Task<IEnumerable<Employee>> GetEmployeeListAsync(CancellationToken cancellationToken = default)
    {
        return employeeRepository.GetAllAsync(cancellationToken);
    }

    public Task DeleteEmployeeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
