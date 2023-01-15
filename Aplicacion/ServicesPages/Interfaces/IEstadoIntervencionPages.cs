using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.EstadoIIntervencion;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IEstadoIntervencionPages
    {
        IEnumerable<EstadoIntervencion> Estados { get; set; }

        Task GetAllEstados();
        Task<EstadoIntervencion> GetEstadoById(int id);
        Task CreateEstado(CreateEstadoIntervencionDto model);
        Task DeleteEstadoById(int id);
        Task UpdateEstado(int id, UpdateEstadoIntervencionDto model);
    }
}
