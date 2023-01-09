using Aplicacion.Services;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Intervencion;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntervencionController : ControllerBase
    {
        private readonly IIntervencionService _intervencionService;

        public IntervencionController(IIntervencionService intervencionService)
        {
            _intervencionService = intervencionService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var intervencionesFromService = await _intervencionService.GetIntervenciones();
            if (intervencionesFromService == null) return NotFound();
            return Ok(intervencionesFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var intervencionFromService = await _intervencionService.GetIntervencionById(id);
            if (intervencionFromService == null) return NotFound();
            return Ok(intervencionFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Intervencion intervencion)
        {
            var newIntervencionFromService = await _intervencionService.CreateIntervencion(intervencion);
            if (newIntervencionFromService == null) return NotFound();
            return Ok(newIntervencionFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Intervencion intervencion)
        {
            var updatedIntervencionFromService = await _intervencionService.UpdateIntervencion(id, intervencion);
            if (updatedIntervencionFromService == null) return NotFound();
            return Ok(updatedIntervencionFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedIntervencionFromService = await _intervencionService.DeleteIntervencion(id);
            if (deletedIntervencionFromService == null) return NotFound();
            return Ok(deletedIntervencionFromService);
        }
    }
}
