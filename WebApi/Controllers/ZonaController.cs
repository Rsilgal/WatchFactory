using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Zona;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonaController : ControllerBase
    {
        private readonly IZonaService _zonaService;

        public ZonaController(IZonaService zonaService)
        {
            _zonaService = zonaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var zonasFromService = await _zonaService.GetZonas();
            if (zonasFromService == null)
                return NotFound();
            return Ok(zonasFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var zonaFromService = await _zonaService.GetZonaById(id);
            if (zonaFromService == null)
                return NotFound();
            return Ok(zonaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateZonaDto dto)
        {
            var zonasFromService = await _zonaService.UpdateZona(id, dto);
            if (zonasFromService == null)
                return NotFound();
            return Ok(zonasFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateZonaDto dto)
        {
            var zonasFromService = await _zonaService.CreateZona(dto);
            if (zonasFromService == null)
                return NotFound();
            return Ok(zonasFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var zonasFromService = await _zonaService.DeleteZona(id);
            if (zonasFromService == null)
                return NotFound();
            return Ok(zonasFromService);
        }

        [HttpGet("page/{skip}/{take}")]
        public async Task<ActionResult> Paginaton(int skip, int take)
        {
            var zonasFromService = await _zonaService.GetAllDataFromZona(skip, take);
            if (zonasFromService == null)
                return NotFound();
            return Ok(zonasFromService);
        }
    }
}
