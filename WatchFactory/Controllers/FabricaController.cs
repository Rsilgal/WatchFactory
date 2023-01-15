using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricaController : ControllerBase
    {
        private readonly IFabricaService _fabricaService;

        public FabricaController(IFabricaService fabricaService) 
        {
            _fabricaService = fabricaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var fabricasFromService = await _fabricaService.GetAllFabricas();
            if (fabricasFromService == null)
                return NotFound();
            return Ok(fabricasFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var fabricaFromService = await _fabricaService.GetFabricaById(id);
            if (fabricaFromService == null)
                return NotFound();
            return Ok(fabricaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateFabricaDto model)
        {
            var fabricasFromService = await _fabricaService.UpdateFabrica(id, model);
            if (fabricasFromService == null) 
            {
                return NotFound();
            }
            return Ok(fabricasFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateFabricaDto model)
        {
            var fabricasFromService = await _fabricaService.CreateFabrica(model);
            if (fabricasFromService == null)
                return NotFound();
            return Ok(fabricasFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var fabricasFromService = await _fabricaService.DeleteFabrica(id);
            if (fabricasFromService == null)
                return NotFound();
            return Ok(fabricasFromService);
        }
    }
}
