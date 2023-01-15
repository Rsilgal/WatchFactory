using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.EstadoIIntervencion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoIntervencionController : ControllerBase
    {
        private readonly IEstadoIntervencionService _estadoService;

        public EstadoIntervencionController(IEstadoIntervencionService estadoService)
        {
            _estadoService = estadoService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var estadosFromService = await _estadoService.GetEstadoIntervencion();
            if (estadosFromService == null)
                return NotFound();
            return Ok(estadosFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var estadoFromService = await _estadoService.GetEstadoIntervencionById(id);
            if (estadoFromService == null)
                return NotFound();
            return Ok(estadoFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateEstadoIntervencionDto model)
        {
            var estadosFromService = await _estadoService.UpdateEstadoIntervencion(id, model);
            if (estadosFromService == null)
                return NotFound();
            return Ok(estadosFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateEstadoIntervencionDto model)
        {
            var estadosFromService = await _estadoService.CreateEstadoIntervencion(model);
            if (estadosFromService == null)
                return NotFound();
            return Ok(estadosFromService);
        }
    }
}
