using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.Categoria;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ICategoriaService
    {
        IEnumerable<Categoria> Categorias { get; set; }

        Task GetAllCategorias();
        Task<Categoria> GetCategoriaByID(int id);
        Task CreateCategoria(CreateCategoriaDto model);
        Task DeleteCategoria(int id);
        Task UpdateCategoria(int id, UpdateCategoriaDto model);
    }
}
