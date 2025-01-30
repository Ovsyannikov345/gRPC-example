using EmployeeGrpc;
using EmployeeService.DAL.Repositories.IRepositories;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace EmployeeService.BLL.Grpc.Services;

public class EmployeeGrpcService(IEmployeeRepository employeeRepository)
    : EmployeeGrpcServiceProto.EmployeeGrpcServiceProtoBase
{
    public override async Task<ProtoEmployee> GetEmployee(GetEmployeeRequest request, ServerCallContext context)
    {
        var employee = await employeeRepository.GetAvailableEmployee(context.CancellationToken);

        return new ProtoEmployee()
        {
            Id = employee.Id.ToString(),
            Name = employee.Name,
            CreatedAt = employee.CreatedAt.ToTimestamp(),
        };
    }
}
