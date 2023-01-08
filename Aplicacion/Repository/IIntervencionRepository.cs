﻿using Dominio.Modelos.Intervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IIntervencionRepository
    {
        Task<List<Intervencion>> GetIntervenciones();
        Task<List<Intervencion>> CreateIntervencion(Intervencion intervencion);

        Task<List<Intervencion>> UpdateIntervencion(int id, Intervencion intervencion);

        Task<List<Intervencion>> DeleteIntervencion(Intervencion intervencion);

        Task<Intervencion> GetIntervencion(int id);
        Task<List<Intervencion>> GetIntervencionesByTipoIntervencion(int TipoIntervencionID);
        Task<List<Intervencion>> GetIntervencionesByEstadoIntervencion(int EstadoIntervencionID);
        Task<List<Intervencion>> GetIntervencionesByTicket(int TicketID);
    }
}
