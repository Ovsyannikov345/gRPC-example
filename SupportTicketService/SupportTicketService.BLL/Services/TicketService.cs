using SupportTicketService.BLL.Services.IServices;
using SupportTicketService.DAL.Entities;
using SupportTicketService.DAL.Repositories.IRepositories;

namespace SupportTicketService.BLL.Services;

public class TicketService(ITicketRepository ticketRepository) : ITicketService
{
    public async Task<Ticket> CreateTicketAsync(Ticket ticket, CancellationToken cancellationToken = default)
    {
        // TODO Assign some employee to the ticket!

        var createdTicket = await ticketRepository.CreateTicketAsync(ticket, cancellationToken);

        return createdTicket;
    }
}
