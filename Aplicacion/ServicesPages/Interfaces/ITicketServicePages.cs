using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Ticket;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface ITicketServicePages
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
        
        Task CreateTicket(CreateTicketDto ticket);
        Task UpdateTicket(int id, UpdateTicketDto ticket);
        Task DeleteTicket(int id);
        Task GetAllTicket();
        Task<Ticket> GetTicket(int id);
        Task GetAllDataFromTickets(int skip, int take);

        Task GetFabricas();
        Task GetLinea();
        Task GetMaquina();
        Task GetCategorias();
        Task GetUrgencia();
        Task GetZona();
        Task GetEstadoIntervencion();
    }
}
