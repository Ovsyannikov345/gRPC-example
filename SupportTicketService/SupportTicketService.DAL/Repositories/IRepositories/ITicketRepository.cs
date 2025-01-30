using SupportTicketService.DAL.Entities;

namespace SupportTicketService.DAL.Repositories.IRepositories;

public interface ITicketRepository
{
    Task<Ticket> CreateTicketAsync(Ticket ticket, CancellationToken cancellationToken = default);
}
