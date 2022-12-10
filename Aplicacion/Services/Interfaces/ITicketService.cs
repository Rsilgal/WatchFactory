using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface ITicketService
    {
        List<Ticket> GetTickets();
        Ticket CreateTicket(Ticket ticket);

        Ticket UpdateTicket(Ticket newTicket);

        Ticket DeleteTicket(Ticket ticket);

        Ticket GetTicket(int id);
    }
}
