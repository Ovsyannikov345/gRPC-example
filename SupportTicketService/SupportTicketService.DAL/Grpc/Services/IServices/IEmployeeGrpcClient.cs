using SupportTicketService.DAL.Grpc.Models;

namespace SupportTicketService.DAL.Grpc.Services.IServices;

public interface IEmployeeGrpcClient
{
    Task<Employee> GetAvailableEmployee(string issueCategory, CancellationToken cancellationToken = default);
}
