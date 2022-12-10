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
            _watchFactory.Tickets.Add(ticket);
            _watchFactory.SaveChanges();

            return ticket;
        }

        public Ticket DeleteTicket(Ticket ticket)
        {
            _watchFactory.Tickets.Remove(ticket);
            _watchFactory.SaveChanges();

            return ticket;
        }

        public Ticket GetTicket(int id)
        {
            return _watchFactory.Tickets.FirstOrDefault(e => e.Id == id);
        }

        public List<Ticket> GetTickets()
        {
            return _watchFactory.Tickets.ToList();
        }

        public Ticket UpdateTicket(Ticket newTicket)
        {
            _watchFactory.Tickets.Update(newTicket);
            _watchFactory.SaveChanges();

            return newTicket;
        }
    }
}
