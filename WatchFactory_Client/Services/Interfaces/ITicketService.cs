﻿using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ITicketService
    {
        List<Maquina> Maquinas { get; set; }
        List<Categoria> Categorias { get; set; }
        List<Usuario> Usuarios { get; set; }
        List<Urgencia> Urgencias { get; set; }
        List<Zona> Zona { get; set; }
        List<EstadoIntervencion> Estados { get; set; }

        List<Ticket> Tickets { get; set; }

        Task CreateTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket);
        Task DeleteTicket(Ticket ticket);
        Task GetAllTicket();
        Task<Ticket> GetTicket(int id);
    }
}
