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

        public Ticket CreateTicket(
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID
            )
        {
            Ticket ticket = new(Descripcion, MaquinaID, CategoriaID, UsuarioID, UrgenciaID, ZonaID, EstadoID);
            return _ticketRepository.CreateTicket(ticket);
        }

        public Ticket DeleteTicket(
            int id
            )
        {
            var ticket = _ticketRepository.GetTicket(id);
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

        public Ticket UpdateTicket(
            int id,
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID
            )
        {
            var newTicket = _ticketRepository.GetTicket(id);
            newTicket.Descripcion= Descripcion;
            newTicket.MaquinaID= MaquinaID;
            newTicket.CategoriaID= CategoriaID;
            newTicket.UsuarioID= UsuarioID;
            newTicket.UrgenciaID= UrgenciaID;
            newTicket.ZonaID= ZonaID;
            newTicket.EstadoID= EstadoID;

            return _ticketRepository.UpdateTicket(newTicket);
        }
    }
}
