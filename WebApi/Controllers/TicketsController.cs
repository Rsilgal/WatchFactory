using Aplicacion.Services;
using Aplicacion.Services.Interfaces;
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
        public ActionResult Post(
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID
            )
        {
            var newTicketFromService = _ticketService.CreateTicket(Descripcion,MaquinaID, CategoriaID, UsuarioID, UrgenciaID, ZonaID, EstadoID);
            if (newTicketFromService == null) return NotFound();
            return Ok(newTicketFromService);
        }

        [HttpPut("{id}")]
        public ActionResult Put(
            int id,
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID
            ) 
        {
            var updatedTicketFromService = _ticketService.UpdateTicket(id, Descripcion, MaquinaID, CategoriaID, UsuarioID, UrgenciaID, ZonaID, EstadoID);
            if (updatedTicketFromService == null) return NotFound();
            return Ok(updatedTicketFromService);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deletedTicketFromService = _ticketService.DeleteTicket(id);
            if (deletedTicketFromService == null) return NotFound();
            return Ok(deletedTicketFromService);
        }
    }
}
