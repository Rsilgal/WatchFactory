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

        public async Task<List<Ticket>> CreateTicket(Ticket ticket)
        {
            await _watchFactory.Tickets.AddAsync(ticket);
            await _watchFactory.SaveChangesAsync();

            return await GetTickets();
        }

        public async Task<List<Ticket>> DeleteTicket(Ticket ticket)
        {
            _watchFactory.Tickets.Remove(ticket);
            await _watchFactory.SaveChangesAsync();

            return await GetTickets();
        }

        public async Task<Ticket> GetTicket(int id)
        {
            var ticket = await _watchFactory.Tickets.
                Where(t => t.Id == id).
                Include(t => t.Urgencia).
                Include(t => t.Categoria).
                Include(t => t.Usuario).
                Include(t => t.Urgencia).
                Include(t => t.Zona).
                Include(t => t.Maquina).
                ThenInclude(m => m.LineaProduccion).
                ThenInclude(lp => lp.Fabrica).
                FirstOrDefaultAsync();

            return ticket;
        }

        public async Task<List<Ticket>> GetTickets()
        {
            var tickets = await _watchFactory.Tickets.
                Include(t => t.Urgencia).
                Include(t => t.Categoria).
                Include(t => t.Usuario).
                Include(t => t.Urgencia).
                Include(t => t.Zona).
                Include(t => t.Maquina).
                ToListAsync();

            return tickets;
        }

        public async Task<List<Ticket>> GetTicketsByFabrica(int FabricaID)
        {
            List<Ticket> tickets;

            tickets = await _watchFactory.Tickets.
                Include(t => t.Maquina).
                ThenInclude(m => m.LineaProduccion).
                Where(t => t.Maquina.LineaProduccion.FabricaID == FabricaID).
                ToListAsync();

            return tickets;
        }

        public async Task<List<Ticket>> GetTicketsByLinea(int LineaID)
        {
            List<Ticket> tickets;

            tickets = await _watchFactory.Tickets.
                Include(t => t.Maquina).
                Where(t => t.Maquina.LineaProduccionID == LineaID).
                ToListAsync();

            return tickets;
        }

        public async Task<List<Ticket>> GetTicketsByTipoMaquina(int TipoMaquinaID)
        {
            List<Ticket> tickets;

            tickets = await _watchFactory.Tickets.
                Include(t => t.Maquina).
                Where(t => t.Maquina.TipoMaquinaID == TipoMaquinaID).
                ToListAsync();
            
            return tickets;
        }

        public async Task<List<Ticket>> UpdateTicket(int id, Ticket ticket)
        {
            var dbTicket = await _watchFactory.Tickets.FirstOrDefaultAsync(e => e.Id == id);
            if (dbTicket == null)
                return null;

            dbTicket.Descripcion = ticket.Descripcion;
            dbTicket.UrgenciaID = ticket.UrgenciaID;
            dbTicket.CategoriaID = ticket.CategoriaID;
            dbTicket.Estado = ticket.Estado;
            dbTicket.MaquinaID = ticket.MaquinaID;
            dbTicket.ZonaID= ticket.ZonaID;

            await _watchFactory.SaveChangesAsync();

            return await GetTickets();
        }
    }
}
