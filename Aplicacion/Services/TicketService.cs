using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Ticket CreateTicket(Ticket ticket)
        {
            return _ticketRepository.CreateTicket(ticket);
        }

        public Ticket DeleteTicket(Ticket ticket)
        {
            return _ticketRepository.DeleteTicket(ticket);
        }

        public Ticket GetTicket(int id)
        {
            return _ticketRepository.GetTicket(id);
        }

        public List<Ticket> GetTickets()
        {
            return _ticketRepository.GetTickets();
        }

        public Ticket UpdateTicket(Ticket newTicket)
        {
            return _ticketRepository.UpdateTicket(newTicket);
        }
    }
}
