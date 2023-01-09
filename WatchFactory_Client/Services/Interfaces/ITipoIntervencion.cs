using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.TipoIntervencion;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ITipoIntervencion
    {
        IEnumerable<TipoIntervencion> Tipos { get; set; }

        Task GetAllTiposIntervencion();
        Task<TipoIntervencion> GetTipoIntervencionById(int id);
        Task CreateTipoIntervencion(CreateTipoIntervencionDto model);
        Task DeleteTipoIntervencion(int id);
        Task UpdateTipoIntervencion(int id, UpdateTipoIntervencionDto model);
    }
}
