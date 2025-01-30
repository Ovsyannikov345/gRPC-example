namespace SupportTicketService.DAL.Grpc.Models;

public class Employee
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public DateTime CreatedAt { get; set; }
}
