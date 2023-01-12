using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Ticket;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public async Task<List<Ticket>> CreateTicket(CreateTicketDto model)
        {
            return await _ticketRepository.CreateTicket(model);
        }

        public async Task<List<Ticket>> DeleteTicket(int id)
        {
            return await _ticketRepository.DeleteTicket(id);
        }

        public async Task<List<Ticket>> GetAllDataFromTickets(int skip, int take)
        {
            return await _ticketRepository.GetAllDataFromTickets(skip, take);
        }

        public async Task<Ticket> GetTicketById(int id)
        {
            return await _ticketRepository.GetTicketById(id);
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _ticketRepository.GetTickets();
        }

        public async Task<List<Ticket>> GetTicketsByFabrica(int FabricaID)
        {
            return await _ticketRepository.GetTicketsByFabrica(FabricaID);
        }

        public async Task<List<Ticket>> GetTicketsByLinea(int LineaID)
        {
            return await _ticketRepository.GetTicketsByLinea(LineaID);
        }

        public async Task<List<Ticket>> GetTicketsByTipoMaquina(int TipoMaquinaID)
        {
            return await _ticketRepository.GetTicketsByTipoMaquina(TipoMaquinaID);
        }

        public async Task<List<Ticket>> UpdateTicket(int id, UpdateTicketDto model)
        {
            return await _ticketRepository.UpdateTicket(id, model);
        }
    }
}
