using SupportTicketService.DAL.Entities;

namespace SupportTicketService.BLL.Services.IServices;

public interface ITicketService
{
    Task<Ticket> CreateTicketAsync(Ticket ticket, CancellationToken cancellationToken = default);
}
