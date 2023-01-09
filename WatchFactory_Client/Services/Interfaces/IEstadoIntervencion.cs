using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.EstadoIIntervencion;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IEstadoIntervencion
    {
        IEnumerable<EstadoIntervencion> Estados { get; set; }

        Task GetAllEstados();
        Task<EstadoIntervencion> GetEstadoById(int id);
        Task CreateEstado(CreateEstadoIntervencionDto model);
        Task DeleteEstadoById(int id);
        Task UpdateEstado(int id, UpdateEstadoIntervencionDto model);
    }
}
