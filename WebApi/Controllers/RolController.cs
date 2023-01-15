using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Rol;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolService;

        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var rolesFromService = await _rolService.GetRols();
            if (rolesFromService == null)
                return NotFound();
            return Ok(rolesFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var rolFromService = await _rolService.GetRolById(id);
            if (rolFromService == null)
                return NotFound();
            return Ok(rolFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateRolDto model)
        {
            var rolesFromService = await _rolService.UpdateRol(id, model);
            if (rolesFromService == null)
                return NotFound();
            return Ok(rolesFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateRolDto model)
        {
            var rolesFromService = await _rolService.CreateRol(model);
            if (rolesFromService == null)
                return NotFound();
            return Ok(rolesFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var rolesFromService = await _rolService.DeleteRol(id);
            if (rolesFromService == null)
                return NotFound();
            return Ok(rolesFromService);
        }

        [HttpGet("page/{skip}/{take}")]
        public async Task<ActionResult> Pagination(int skip, int take)
        {
            var rolesFromService = await _rolService.GetAllDataFromRol(skip, take);
            if (rolesFromService == null)
                return NotFound();
            return Ok(rolesFromService);
        }
    }
}
