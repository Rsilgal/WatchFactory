using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Intervencion;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IIntervencion
    {
        IEnumerable<Intervencion> Intervencions { get; set; }
        IEnumerable<TipoIntervencion> Tipos { get; set; }
        IEnumerable<EstadoIntervencion> Estados { get; set; }

        Task GetAllIntervenciones();
        Task GetIntervencionById(int id);
        Task CreateIntervencion(CreateIntervencionDto model);
        Task DeleteIntervencion(int id);
        Task UpdateIntervencion(UpdateIntervencionDto model);

        Task GetTipos();
        Task GetEstados();
    }
}
