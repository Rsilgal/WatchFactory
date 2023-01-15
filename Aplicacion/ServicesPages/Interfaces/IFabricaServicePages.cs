using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IFabricaServicePages
    {
        IEnumerable<Fabrica> Fabricas { get; set; }
        Task GetAllFabrica();
        Task<Fabrica> GetFabricaById(int id);
        Task CreateFabrica(CreateFabricaDto model);
        Task DeleteFabricaById(int id);
        Task UpdateFabrica(int id, UpdateFabricaDto model);

    }
}
