using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.Maquina;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IMaquinaService
    {
        IEnumerable<Maquina> Maquinas { get; set; }
        IEnumerable<TipoMaquina> Tipos { get; set; }
        IEnumerable<LineaProduccion> Lineas { get; set; }
        IEnumerable<Fabrica> Fabricas { get; set; }

        Task GetAllMaquinas();
        Task<Maquina> GetMaquinaById(int id);
        Task CreateMaquina(CreateMaquinaDto model);
        Task DeleteMaquina(int id);
        Task UpdateMaquina(int id, UpdateMaquinaDto model);

        Task GetAllTipoMaquina();
        Task GetAllLineas();
        Task GetAllFabricas();
    }
}
