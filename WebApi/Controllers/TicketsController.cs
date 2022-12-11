using Aplicacion.Services;
using Dominio.Modelos.Nucleo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly TicketService _ticketService;

        public TicketsController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var ticketsFromService = _ticketService.GetTickets();
            if (ticketsFromService == null) return NotFound();
            return Ok(ticketsFromService);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var ticketFromService = _ticketService.GetTicket(id);
            if (ticketFromService == null) return NotFound();
            return Ok(ticketFromService);
        }

        [HttpPost]
        public ActionResult Post(Ticket ticket)
        {
            var newTicketFromService = _ticketService.CreateTicket(ticket);
            if (newTicketFromService == null) return NotFound();
            return Ok(newTicketFromService);
        }

        [HttpPut("{id}")]
        public ActionResult Put(Ticket ticket) 
        {
            var updatedTicketFromService = _ticketService.UpdateTicket(ticket);
            if (updatedTicketFromService == null) return NotFound();
            return Ok(updatedTicketFromService);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var ticketFromService = _ticketService.GetTicket(id);
            var deletedTicketFromService = _ticketService.DeleteTicket(ticketFromService);
            if (deletedTicketFromService == null) return NotFound();
            return Ok(deletedTicketFromService);
        }
    }
}
