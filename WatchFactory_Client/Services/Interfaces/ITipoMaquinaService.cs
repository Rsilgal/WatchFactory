using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoMaquina;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ITipoMaquinaService
    {
        IEnumerable<TipoMaquina> TiposMaquinas { get; set; }

        Task GetTiposMaquinas();
        Task<TipoMaquina> GetTipoMaquinaById(int id);
        Task CreateTipoMaquina(CreateTipoMaquinaDto model);
        Task DeleteTipoMaquina(int id);
        Task UpdateTipoMaquina(int id, UpdateTipoMaquinaDto model);
        Task GetAllDataFromTipoMaquina(int skip, int take);
    }
}
