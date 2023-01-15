using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Categoria;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface ICategoriaServicePages
    {
        IEnumerable<Categoria> Categorias { get; set; }

        Task GetAllCategorias();
        Task<Categoria> GetCategoriaByID(int id);
        Task CreateCategoria(CreateCategoriaDto model);
        Task DeleteCategoria(int id);
        Task UpdateCategoria(int id, UpdateCategoriaDto model);
    }
}
