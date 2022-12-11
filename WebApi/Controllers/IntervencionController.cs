using Aplicacion.Services;
using Dominio.Modelos.Intervencion;
using Microsoft.AspNetCore.Http;
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
        public ActionResult Post(Intervencion intervencion)
        {
            var newIntervencionFromService = _intervencionService.CreateIntervencion(intervencion);
            if (newIntervencionFromService == null) return NotFound();
            return Ok(newIntervencionFromService);
        }

        [HttpPut("{id}")]
        public ActionResult Update(Intervencion intervencion)
        {
            var updatedIntervencionFromService = _intervencionService.UpdateIntervencion(intervencion);
            if (updatedIntervencionFromService == null) return NotFound();
            return Ok(updatedIntervencionFromService);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var intervencionFromService = _intervencionService.GetIntervencion(id);
            var deletedIntervencionFromService = _intervencionService.DeleteIntervencion(intervencionFromService);
            if (deletedIntervencionFromService == null) return NotFound();
            return Ok(deletedIntervencionFromService);
        }
    }
}
