using EmployeeGrpc;
using SupportTicketService.DAL.Grpc.Models;
using SupportTicketService.DAL.Grpc.Services.IServices;

namespace SupportTicketService.DAL.Grpc.Services;

public class EmployeeGrpcClient(EmployeeGrpcServiceProto.EmployeeGrpcServiceProtoClient client) : IEmployeeGrpcClient
{
    public async Task<Employee> GetAvailableEmployee(string issueCategory, CancellationToken cancellationToken = default)
    {
        var request = new GetEmployeeRequest { IssueCategory = issueCategory };

        var employee = await client.GetEmployeeAsync(request, cancellationToken: cancellationToken);

        return new Employee()
        {
            Id = Guid.Parse(employee.Id),
            Name = employee.Name,
            CreatedAt = employee.CreatedAt.ToDateTime()
        };
    }
}
