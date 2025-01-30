using EmployeeService.DAL.Entities;

namespace EmployeeService.DAL.Repositories.IRepositories;

public interface IEmployeeRepository : IGenericRepository<Employee>
{
    Task<Employee> GetAvailableEmployee(CancellationToken cancellationToken = default);
}
