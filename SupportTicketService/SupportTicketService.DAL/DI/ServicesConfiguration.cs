using Microsoft.Extensions.DependencyInjection;
using SupportTicketService.DAL.Repositories;
using SupportTicketService.DAL.Repositories.IRepositories;

namespace SupportTicketService.DAL.DI;

public static class ServicesConfiguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services)
    {
        services.AddScoped<ITicketRepository, TicketRepositoryMock>();
    }
}
