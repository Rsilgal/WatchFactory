using Aplicacion.Services;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Ticket;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using Infraestructura;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var ticketsFromService = await _ticketService.GetTickets();
            if (ticketsFromService == null) return NotFound();
            return Ok(ticketsFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var ticketFromService = await _ticketService.GetTicketById(id);
            if (ticketFromService == null) return NotFound();
            return Ok(ticketFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateTicketDto model)
        {
            var newTicketFromService = await _ticketService.CreateTicket(model);
            if (newTicketFromService == null) return NotFound();
            return Ok(newTicketFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateTicketDto model) 
        {
            var updatedTicketFromService = await _ticketService.UpdateTicket(id, model);
            if (updatedTicketFromService == null) return NotFound();
            return Ok(updatedTicketFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedTicketFromService = await _ticketService.DeleteTicket(id);
            if (deletedTicketFromService == null) return NotFound();
            return Ok(deletedTicketFromService);
        }
    }
}
