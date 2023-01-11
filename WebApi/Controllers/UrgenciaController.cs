using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Urgencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrgenciaController : ControllerBase
    {
        private readonly IUrgenciaService _urgenciaService;

        public UrgenciaController(IUrgenciaService urgenciaService)
        {
            _urgenciaService = urgenciaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var urgenciasFromService = await _urgenciaService.GetUrgencias();
            if (urgenciasFromService == null)
                return NotFound();
            return Ok(urgenciasFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var urgenciaFromService = await _urgenciaService.GetUrgenciaById(id);
            if (urgenciaFromService == null)
                return NotFound();
            return Ok(urgenciaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateUrgenciaDto dto)
        {
            var urgenciasFromService = await _urgenciaService.UpdateUrgencia(id, dto);
            if (urgenciasFromService == null)
                return NotFound();
            return Ok(urgenciasFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateUrgenciaDto dto)
        {
            var urgenciasFromService = await _urgenciaService.CreateUrgencia(dto);
            if (urgenciasFromService == null)
                return NotFound();
            return Ok(urgenciasFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var urgenciasFromService = await _urgenciaService.DeleteUrgencia(id);
            if (urgenciasFromService == null)
                return NotFound();
            return Ok(urgenciasFromService);
        }

        [HttpGet("page/{skip}/{take}")]
        public async Task<ActionResult> Pagination(int skip, int take)
        {
            var urgenciasFromService = await _urgenciaService.GetAllDataFromUrgencias(skip, take);
            if (urgenciasFromService == null)
                return NotFound();
            return Ok(urgenciasFromService);
        }
    }
}
