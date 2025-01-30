using EmployeeService.BLL.Services.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeService.BLL.DI;

public static class ServicesConfiguration
{
    public static void AddBusinessLogicDependencies(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, Services.EmployeeService>();
    }
}
