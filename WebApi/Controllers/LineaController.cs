using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.LineaProduccion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineaController : ControllerBase
    {
        private readonly ILinneaProduccionService _lineaService;

        public LineaController(ILinneaProduccionService lineaService)
        {
            _lineaService = lineaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var lineasFromService = await _lineaService.GetAllLineasProduccion();
            if (lineasFromService == null)
                return NotFound();
            return Ok(lineasFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var lineaFromService = await _lineaService.GetLineaById(id);
            if (lineaFromService == null)
                return NotFound();
            return Ok(lineaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateLineaDto model)
        {
            var lineasFromService = await _lineaService.UpdateLinea(id, model);
            if (lineasFromService == null)
                return NotFound();
            return Ok(lineasFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateLineaDto model)
        {
            var lineasFromService = await _lineaService.CreateLineaProduccion(model);
            if (lineasFromService == null)
                return NotFound();
            return Ok(lineasFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var lineasFromService = await _lineaService.DeleteLinea(id);
            if (lineasFromService == null)
                return NotFound();
            return Ok(lineasFromService);
        }
    }
}
