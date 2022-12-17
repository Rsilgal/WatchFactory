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
        //Ticket CreateTicket(Ticket ticket);
        Ticket CreateTicket({
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID,
            });

        // Ticket UpdateTicket(Ticket newTicket);
        Ticket UpdateTicket(
            {
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID,
            });

        // Ticket DeleteTicket(Ticket ticket);
        Ticket DeleteTicket({
            string Descripcion,
            int MaquinaID,
            int CategoriaID,
            int UsuarioID,
            int UrgenciaID,
            int ZonaID,
            int EstadoID,
            });

        Ticket GetTicket(int id);
    }
}
