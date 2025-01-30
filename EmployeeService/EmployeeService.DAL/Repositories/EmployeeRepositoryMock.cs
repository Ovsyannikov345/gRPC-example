using Bogus;
using EmployeeService.DAL.Entities;
using EmployeeService.DAL.Repositories.IRepositories;

namespace EmployeeService.DAL.Repositories;

public class EmployeeRepositoryMock : IEmployeeRepository
{
    private readonly Faker<Employee> _faker = new Faker<Employee>()
        .RuleFor(e => e.Id, f => Guid.NewGuid())
        .RuleFor(e => e.Name, f => f.Name.FullName());

    public Task<Employee> GetAvailableEmployee(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_faker.Generate());
    }

    public Task<Employee> CreateAsync(Employee entity, CancellationToken cancellationToken = default)
    {
        entity.Id = Guid.NewGuid();

        return Task.FromResult(entity);
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task<IEnumerable<Employee>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_faker.Generate(10).AsEnumerable());
    }

    public Task<Employee> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = _faker.Generate();

        employee.Id = id;

        return Task.FromResult(employee);
    }
}
