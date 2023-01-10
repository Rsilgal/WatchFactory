using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Maquina;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaquinaController : ControllerBase
    {
        private readonly IMaquinaService _maquinaService;

        public MaquinaController(IMaquinaService maquinaService)
        {
            _maquinaService = maquinaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var maquinasFromService = await _maquinaService.GetAllMaquinas();
            if (maquinasFromService == null)
                return NotFound();
            return Ok(maquinasFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var maquinaFromService = await _maquinaService.GetMaquinaById(id);
            if (maquinaFromService == null)
                return NotFound();
            return Ok(maquinaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateMaquinaDto model)
        {
            var maquinasFromService = await _maquinaService.UpdateMaquina(id, model);
            if (maquinasFromService == null)
                return NotFound();
            return Ok(maquinasFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateMaquinaDto model)
        {
            var maquinasFromService = await _maquinaService.CreateMaquina(model);
            if (maquinasFromService == null)
                return NotFound();
            return Ok(maquinasFromService);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var maquinasFromService = await _maquinaService.DeleteMaquina(id);
            if (maquinasFromService == null)
                return NotFound();
            return Ok(maquinasFromService);
        }
    }
}
