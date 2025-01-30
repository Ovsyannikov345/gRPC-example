using Microsoft.AspNetCore.Mvc;
using SupportTicketService.BLL.Services.IServices;
using SupportTicketService.DAL.Entities;
using SupportTicketService.ViewModels;

namespace SupportTicketService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController(ITicketService ticketService) : ControllerBase
    {
        [HttpPost(Name = "CreateTicket")]
        public async Task<Ticket> CreateTicket(TicketToCreateViewModel ticketData, CancellationToken cancellationToken = default)
        {
            var ticketToCreate = new Ticket()
            {
                Category = ticketData.Category,
                Description = ticketData.Description
            };

            return await ticketService.CreateTicketAsync(ticketToCreate, cancellationToken);
        }
    }
}
