using Aplicacion.Repository;
using Dominio.Modelos.Nucleo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            var tickets = _watchFactory.Tickets.ToList();
            return tickets;
        }

        public List<Ticket> GetTicketsByFabrica(int FabricaID)
        {
            List<Ticket> tickets;

            // Si el ID de Fabrica es 2
            var linea = _watchFactory.Lineas.Where(e => e.FabricaID == FabricaID).ToList();
            if (linea == null) throw new Exception("No existe linea asociada a la fabrica mencioanda.");

            // Extraemos las máquinas asociadas a la línea
            var maquinas = _watchFactory.Maquinas.Where(e => linea.All(l => l.Id == e.LineaProduccionID)).ToList();
            if (maquinas == null) throw new Exception("No existen maquinas asociadas a los datos indicados.");

            tickets = _watchFactory.Tickets.Where(e => maquinas.All(m => m.Id == e.MaquinaID)).ToList();


            return tickets;
        }

        public List<Ticket> GetTicketsByLinea(int LineaID)
        {
            List<Ticket> tickets;

            var maquinas = _watchFactory.Maquinas.Where(e => e.LineaProduccionID == LineaID).ToList();
            if (maquinas == null) throw new Exception("No existen maquinas asociadas a los datos indicados.");

            tickets = _watchFactory.Tickets.Where(e => maquinas.All(m => m.Id == e.MaquinaID)).ToList();


            return tickets;
        }

        public List<Ticket> GetTicketsByTipoMaquina(int TipoMaquinaID)
        {
            List<Ticket> tickets;

            var maquinas = _watchFactory.Maquinas.Where(e => e.TipoMaquinaID == TipoMaquinaID).ToList();
            if (maquinas == null) throw new Exception("No existen maquinas asociadas a los datos indicados.");

            tickets = _watchFactory.Tickets.Where(e => maquinas.All(m => m.Id == e.MaquinaID)).ToList();


            return tickets;
        }

        public Ticket UpdateTicket(Ticket newTicket)
        {
            _watchFactory.Tickets.Update(newTicket);
            _watchFactory.SaveChanges();

            return newTicket;
        }
    }
}
