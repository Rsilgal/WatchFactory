using Dominio.Modelos.Configuracion;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IIntervencionService
    {
        List<Intervencion> Intervenciones { get; set; }
        List<Ticket> Tickets { get; set; }
        List<EstadoIntervencion> Estados { get; set; }
        List<TipoIntervencion> Tipos { get; set; }

        Task GetIntervenciones();
        Task<Intervencion> GetIntervencion(int id);
        Task CreateIntervencion(Intervencion intervencion);
        Task DeleteIntervencion(int id);
        Task UpdateIntervencion(Intervencion intervencion);
        Task GetEstadoIntervencion();
        Task GetTipoIntervencion();
    }
}
