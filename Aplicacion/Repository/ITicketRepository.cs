using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetTickets();
        Task<List<Ticket>> CreateTicket(Ticket ticket);

        Task<List<Ticket>> UpdateTicket(int id, Ticket ticket);

        Task<List<Ticket>> DeleteTicket(Ticket ticket);

        Task<Ticket> GetTicket(int id);
        Task<List<Ticket>> GetTicketsByFabrica(int FabricaID);
        Task<List<Ticket>> GetTicketsByLinea(int LineaID);
        Task<List<Ticket>> GetTicketsByTipoMaquina(int TipoMaquinaID);
    }
}
