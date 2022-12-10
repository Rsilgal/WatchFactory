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

        public List<Ticket> GetTickets()
        {
            return _ticketRepository.GetTickets();
        }
    }
}
