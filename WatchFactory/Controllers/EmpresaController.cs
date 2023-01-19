using Dominio.Modelos.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WatchFactory.Data;

namespace WatchFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public EmpresaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var data = await _db.Empresa.Include(e => e.EstadoInicial).FirstOrDefaultAsync();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Empresa empresa)
        {
            var company = await _db.Empresa.Include(e => e.EstadoInicial).FirstOrDefaultAsync();
            if (company == null)
            {
                return NotFound();
            }

            company.Nombre = empresa.Nombre;
            company.Logo = empresa.Logo;
            company.Eslogan = empresa.Eslogan;
            company.Codigo= empresa.Codigo;
            company.Descripcion = empresa.Descripcion;
            //company.FechaCreacion = empresa.FechaCreacion;
            company.EstadoInicial = empresa.EstadoInicial;

            await _db.SaveChangesAsync();
            return Ok(company);
        }

        [HttpGet("name")]
        public async Task<ActionResult> GetName()
        {
            var name = await _db.Empresa.Select(x => x.Nombre).FirstOrDefaultAsync();
            if (name == null)
            {
                return NotFound();
            }
            return Ok(name);
        }
    }
}
