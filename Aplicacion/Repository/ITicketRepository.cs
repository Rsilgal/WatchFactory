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
        List<Ticket> GetTickets();
        Ticket CreateTicket(Ticket ticket);
    }
}
