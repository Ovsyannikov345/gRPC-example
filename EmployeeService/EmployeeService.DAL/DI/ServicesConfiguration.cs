using EmployeeService.DAL.Repositories;
using EmployeeService.DAL.Repositories.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeService.DAL.DI;

public static class ServicesConfiguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepositoryMock>();
    }
}
