using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IFabricaService
    {
        IEnumerable<Fabrica> Fabricas { get; set; }
        Task GetAllFabrica();
        Task<Fabrica> GetFabricaById(int id);
        Task CreateFabrica(CreateFabricaDto model);
        Task DeleteFabricaById(int id);
        Task UpdateFabrica(int id, UpdateFabricaDto model);

    }
}
