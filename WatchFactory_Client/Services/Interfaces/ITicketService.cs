using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ITicketService
    {
        List<Fabrica> Fabricas { get; set; }
        List<LineaProduccion> Lineas { get; set; }
        List<Maquina> Maquinas { get; set; }
        List<Categoria> Categorias { get; set; }
        List<Usuario> Usuarios { get; set; }
        List<Urgencia> Urgencias { get; set; }
        List<Zona> Zonas { get; set; }
        List<EstadoIntervencion> Estados { get; set; }

        List<Ticket> Tickets { get; set; }
        
        Task CreateTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket);
        Task DeleteTicket(int id);
        Task GetAllTicket();
        Task<Ticket> GetTicket(int id);

        Task GetFabricas();
        Task GetLineas();
        Task GetMaquinas();
        Task GetCategorias();
        Task GetUsuarios();
        Task GetUrgencias();
        Task GetZonas();
        Task GetEstados();
    }
}
