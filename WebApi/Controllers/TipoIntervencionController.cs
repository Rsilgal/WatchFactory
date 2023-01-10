using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.TipoIntervencion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIntervencionController : ControllerBase
    {
        private readonly ITipoIntervencionService _intervencionService;

        public TipoIntervencionController(ITipoIntervencionService intervencionService)
        {
            _intervencionService = intervencionService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var tiposFromService = await _intervencionService.GetTipoIntervencion();
            if (tiposFromService == null) 
                return NotFound();
            return Ok(tiposFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var tipoFromService = await _intervencionService.GetTipoIntervecionById(id);
            if (tipoFromService == null)
                return NotFound();
            return Ok(tipoFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateTipoIntervencionDto model)
        {
            var tiposFromService = await _intervencionService.UpdateTipoIntervecion(id, model);
            if (tiposFromService == null)
                return NotFound();
            return Ok(tiposFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateTipoIntervencionDto model)
        {
            var tiposFromService = await _intervencionService.CreateTipoIntervencion(model);
            if (tiposFromService == null)
                return NotFound();
            return Ok(tiposFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var tiposFromService = await _intervencionService.DeleteTipoIntervencion(id);
            if (tiposFromService == null)
                return NotFound();
            return Ok(tiposFromService);
        }
    }
}
