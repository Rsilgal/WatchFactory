using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.TipoMaquina;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoMaquinaController : ControllerBase
    {
        private readonly ITipoMaquinaService _tipoMaquinaService;

        public TipoMaquinaController(ITipoMaquinaService tipoMaquinaService)
        {
            _tipoMaquinaService = tipoMaquinaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var tiposMaquinaFromService = await _tipoMaquinaService.GetAllTipoMaquinas();
            if (tiposMaquinaFromService == null)
                return NotFound();
            return Ok(tiposMaquinaFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var tipoMaquinaFromService = await _tipoMaquinaService.GetTipoMaquinaById(id);
            if (tipoMaquinaFromService == null)
                return NotFound();
            return Ok(tipoMaquinaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateTipoMaquinaDto model)
        {
            var tiposMaquinaFromService = await _tipoMaquinaService.UpdateTipoMaquina(id, model);
            if (tiposMaquinaFromService == null)
                return NotFound();
            return Ok(tiposMaquinaFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateTipoMaquinaDto model)
        {
            var tiposMaquinaFromService = await _tipoMaquinaService.CreateTipoMaquina(model);
            if (tiposMaquinaFromService == null)
                return NotFound();
            return Ok(tiposMaquinaFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var tiposMaquinaFromService = await _tipoMaquinaService.DeleteTipoMaquina(id);
            if (tiposMaquinaFromService == null)
                return NotFound();
            return Ok(tiposMaquinaFromService);
        }

        [HttpGet("page/{skip}/{take}")]
        public async Task<ActionResult> Pagination(int skip, int take)
        {
            var tiposMaquinaFromService = await _tipoMaquinaService.GetAllDataFromTipoMaquinas(skip, take);
            if (tiposMaquinaFromService == null)
                return NotFound();
            return Ok(tiposMaquinaFromService);
        }
    }
}
