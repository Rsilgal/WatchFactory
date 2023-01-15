using Aplicacion.Repository;
using Dominio.Modelos.Dtos.Intervencion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchFactory.Data;

namespace Infraestructura.Repository
{
    public class IntervencionRepository : IIntervencionRepository
    {
        private readonly ApplicationDbContext _watchFactory;

        public IntervencionRepository(ApplicationDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Intervencion>> CreateIntervencion(CreateIntervencionDto model)
        {
            await _watchFactory.Intervenciones.AddAsync(new Intervencion
            {
                Descripcion= model.Descripcion,
                FechaCreacion = DateTime.Now,
                TicketID = model.TicketId,
                EstadoIntervencionID = model.EstadoId,
                TipoIntervencionID = model.TipoId,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetIntervenciones();
        }

        public async Task<List<Intervencion>> DeleteIntervencion(int id)
        {
            var intervencion = await _watchFactory.Intervenciones.FirstOrDefaultAsync(x => x.Id == id);
            if (intervencion == null) 
            {
                return null;
            }
            _watchFactory.Intervenciones.Remove(intervencion);
            await _watchFactory.SaveChangesAsync();
            
            return await GetIntervenciones();
        }

        public async Task<List<Intervencion>> GetAllDataFromIntervenciones(int skip, int take)
        {
            return await _watchFactory.Intervenciones
                .Include(i => i.Ticket)
                .Include(i => i.EstadoIntervencion)
                .Include(i => i.TipoIntervencion)
                .ToListAsync();
        }

        public async Task<Intervencion> GetIntervencion(int id)
        {
            var intervencion = await _watchFactory.Intervenciones.
                Include(e => e.Ticket).
                Include(e => e.TipoIntervencion).
                Include(e => e.EstadoIntervencion).
                Where(e => e.Id == id).
                FirstOrDefaultAsync();
            
            return intervencion;
        }

        public async Task<List<Intervencion>> GetIntervenciones()
        {
            return await _watchFactory.Intervenciones
                .ToListAsync();
        }

        public async Task<List<Intervencion>> GetIntervencionesByEstadoIntervencion(int EstadoIntervencionID)
        {
            var intervenciones = await _watchFactory.Intervenciones.
                Where(e => e.EstadoIntervencionID == EstadoIntervencionID).ToListAsync();

            return intervenciones;
        }

        public async Task<List<Intervencion>> GetIntervencionesByTicket(int TicketID)
        {
            var intervenciones = await _watchFactory.Intervenciones.
                Where(e => e.TicketID == TicketID).ToListAsync();
            
            return intervenciones;
        }

        public async Task<List<Intervencion>> GetIntervencionesByTipoIntervencion(int TipoIntervencionID)
        {
            var intervenciones = await _watchFactory.Intervenciones.
                Where(e => e.TipoIntervencionID == TipoIntervencionID).ToListAsync();

            return intervenciones;
        }

        public async Task<List<Intervencion>> UpdateIntervencion(int id, UpdateIntervencionDto model)
        {
            var dbIntervencion = await _watchFactory.Intervenciones.FirstOrDefaultAsync(e => e.Id == id);
            if (dbIntervencion == null)
                return null;

            dbIntervencion.Descripcion = model.Descripcion;
            dbIntervencion.TipoIntervencionID = model.TipoId;
            dbIntervencion.EstadoIntervencionID = model.EstadoId;

            await _watchFactory.SaveChangesAsync();

            return await GetIntervenciones();
        }
    }
}
