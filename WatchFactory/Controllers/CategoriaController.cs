using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Categoria;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var categoriasFromService = await _categoriaService.GetCategorias();
            if (categoriasFromService == null) 
                return NotFound();
            return Ok(categoriasFromService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id) 
        {
            var categoriaFromService = await _categoriaService.GetCategoriaById(id);
            if (categoriaFromService == null)
                return NotFound();
            return Ok(categoriaFromService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateCategoriaDto model)
        {
            var categoriasFromService = await _categoriaService.UpdateCategoria(id, model);
            if (categoriasFromService == null)
                return NotFound();
            return Ok(categoriasFromService);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateCategoriaDto model)
        {
            var categoriasFromService = await _categoriaService.CreateCategoria(model);
            if (categoriasFromService == null)
                return NotFound();
            return Ok(categoriasFromService);
        }
    }
}
