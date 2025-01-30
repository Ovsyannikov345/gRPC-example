using Microsoft.Extensions.DependencyInjection;
using SupportTicketService.BLL.Services;
using SupportTicketService.BLL.Services.IServices;

namespace SupportTicketService.BLL.DI;

public static class ServicesConfiguration
{
    public static void AddBusinessLogicDependencies(this IServiceCollection services)
    {
        services.AddScoped<ITicketService, TicketService>();
    }
}
