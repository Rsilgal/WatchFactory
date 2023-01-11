using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Permiso;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisoController : ControllerBase
    {
        private readonly IPermisoService _permisoService;

        public PermisoController(IPermisoService permisoService)
        {
            _permisoService = permisoService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var permisosFromService = await _permisoService.GetPermisos();
            if (permisosFromService == null)
                return NotFound();
            return Ok(permisosFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var permisoFromService = await _permisoService.GetPermisoById(id);
            if (permisoFromService == null)
                return NotFound();
            return Ok(permisoFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdatePermisoDto model)
        {
            var permisosFromService = await _permisoService.UpdatePermiso(id, model);
            if (permisosFromService == null)
                return NotFound();
            return Ok(permisosFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreatePermisoDto model)
        {
            var permisosFromService = await _permisoService.CreatePermiso(model);
            if (permisosFromService == null)
                return NotFound();
            return Ok(permisosFromService);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var permisosFromService = await _permisoService.DeletePermiso(id);
            if (permisosFromService == null)
                return NotFound();
            return Ok(permisosFromService);
        }

        [HttpGet("page/{skip}/{take}")]
        public async Task<ActionResult> Pagination(int skip, int take)
        {
            var permisosFromService = await _permisoService.GetAllDataFromPermisos(skip, take);
            if (permisosFromService != null)
                return NotFound();
            return Ok(permisosFromService);
        }
    }
}
