using EmployeeGrpc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SupportTicketService.DAL.Grpc.Services;
using SupportTicketService.DAL.Grpc.Services.IServices;
using SupportTicketService.DAL.Repositories;
using SupportTicketService.DAL.Repositories.IRepositories;

namespace SupportTicketService.DAL.DI;

public static class ServicesConfiguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITicketRepository, TicketRepositoryMock>();

        services.AddGrpcClient<EmployeeGrpcServiceProto.EmployeeGrpcServiceProtoClient>(options =>
            options.Address = new Uri(configuration.GetConnectionString("EmployeeService")!));

        services.AddScoped<IEmployeeGrpcClient, EmployeeGrpcClient>();
    }
}
