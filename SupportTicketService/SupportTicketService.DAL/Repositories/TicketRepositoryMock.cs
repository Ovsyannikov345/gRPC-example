using SupportTicketService.DAL.Entities;
using SupportTicketService.DAL.Repositories.IRepositories;

namespace SupportTicketService.DAL.Repositories;

public class TicketRepositoryMock : ITicketRepository
{
    public Task<Ticket> CreateTicketAsync(Ticket ticket, CancellationToken cancellationToken = default)
    {
        ticket.Id = Guid.NewGuid();

        return Task.FromResult(ticket);
    }
}
