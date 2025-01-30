using EmployeeService.DAL.Entities;

namespace EmployeeService.BLL.Services.IServices;

public interface IEmployeeService
{
    Task<Employee> CreateEmployeeAsync(Employee employee, CancellationToken cancellationToken = default);

    Task<Employee> GetEmployeeAsync(Guid id, CancellationToken cancellationToken = default);

    Task<IEnumerable<Employee>> GetEmployeeListAsync(CancellationToken cancellationToken = default);

    Task DeleteEmployeeAsync(Guid id, CancellationToken cancellationToken = default);
}
