using Aplicacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntervencionController : ControllerBase
    {
        private readonly IntervencionService _intervencionService;

        public IntervencionController(IntervencionService intervencionService)
        {
            _intervencionService = intervencionService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var intervencionesFromService = _intervencionService.GetIntervenciones();
            if (intervencionesFromService == null) return NotFound();
            return Ok(intervencionesFromService);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var intervencionFromService = _intervencionService.GetIntervencion(id);
            if (intervencionFromService == null) return NotFound();
            return Ok(intervencionFromService);
        }

        [HttpPost]
        public ActionResult Post(string Descripcion, int TicketID, int EstadoIntervencionID, int TipoIntervencionID)
        {
            var newIntervencionFromService = _intervencionService.CreateIntervencion(Descripcion, TicketID, EstadoIntervencionID, TipoIntervencionID);
            if (newIntervencionFromService == null) return NotFound();
            return Ok(newIntervencionFromService);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, string Descripcion, int TicketID, int EstadoIntervencionID, int TipoIntervencionID)
        {
            var updatedIntervencionFromService = _intervencionService.UpdateIntervencion(id, Descripcion, TicketID, EstadoIntervencionID, TipoIntervencionID);
            if (updatedIntervencionFromService == null) return NotFound();
            return Ok(updatedIntervencionFromService);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deletedIntervencionFromService = _intervencionService.DeleteIntervencion(id);
            if (deletedIntervencionFromService == null) return NotFound();
            return Ok(deletedIntervencionFromService);
        }
    }
}
