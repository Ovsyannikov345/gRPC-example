namespace EmployeeService.DAL.Entities;

public class Employee
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
