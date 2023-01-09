using WatchFactory_Client.Models.Dtos.TipoMaquina;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ITipoMaquinaService
    {
        IEnumerable<ITipoMaquinaService> TiposMaquinas { get; set; }

        Task GetTiposMaquinas();
        Task GetTipoMaquinaById(int id);
        Task CreateTipoMaquina(CreateTipoMaquinaDto model);
        Task DeleteTipoMaquina(int id);
        Task UpdateTipoMaquina(UpdateTipoMaquinaDto model);
    }
}
