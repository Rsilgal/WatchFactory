using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Intervencion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IIntervencionServicePages
    {
        List<Intervencion> Intervenciones { get; set; }
        List<Ticket> Tickets { get; set; }
        List<EstadoIntervencion> Estados { get; set; }
        List<TipoIntervencion> Tipos { get; set; }

        Task GetIntervenciones();
        Task<Intervencion> GetIntervencion(int id);
        Task CreateIntervencion(CreateIntervencionDto intervencion);
        Task DeleteIntervencion(int id);
        Task UpdateIntervencion(int id, UpdateIntervencionDto intervencion);
        Task GetEstadoIntervencion();
        Task GetTipoIntervencion();

        Task GetAllDataFromIntervencion(int id, int skip, int take);
    }
}
