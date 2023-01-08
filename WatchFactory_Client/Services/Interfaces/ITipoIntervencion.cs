using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.TipoIntervencion;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ITipoIntervencion
    {
        IEnumerable<TipoIntervencion> TiposIntervencion { get; set; }

        Task GetAllTiposIntervencion();
        Task GetTipoIntervencionById(int id);
        Task CreateTipoIntervencion(CreateTipoIntervencionDto model);
        Task DeleteTipoIntervencion(int id);
        Task UpdateTipoIntervencion(UpdateTipoIntervencionDto model);
    }
}
