using Aplicacion.Repository;
using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public TicketRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public Ticket CreateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetTickets()
        {
            throw new NotImplementedException();
        }
    }
}
