namespace SupportTicketService.DAL.Entities;

public class Ticket
{
    public Guid Id { get; set; }

    public required string Category { get; set; }

    public required string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Guid EmployeeId { get; set; }
}
