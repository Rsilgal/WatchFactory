using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.Categoria;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ICategoriaService
    {
        IEnumerable<Categoria> categorias { get; set; }

        Task GetAllCategorias();
        Task GetCategoriaByID(int id);
        Task CreateCategoria(CreateCategoriaDto model);
        Task DeleteCategoria(int id);
        Task UpdateCategoria(UpdateCategoriaDto model);
    }
}
