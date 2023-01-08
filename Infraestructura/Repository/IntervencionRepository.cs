using Aplicacion.Repository;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class IntervencionRepository : IIntervencionRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public IntervencionRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Intervencion>> CreateIntervencion(Intervencion intervencion)
        {
            await _watchFactory.Intervenciones.AddAsync(intervencion);
            await _watchFactory.SaveChangesAsync();

            return await GetIntervenciones();
        }

        public async Task<List<Intervencion>> DeleteIntervencion(Intervencion intervencion)
        {
            _watchFactory.Intervenciones.Remove(intervencion);
            await _watchFactory.SaveChangesAsync();
            
            return await GetIntervenciones();
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
            return await _watchFactory.Intervenciones.ToListAsync();
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

        public async Task<List<Intervencion>> UpdateIntervencion(int id, Intervencion intervencion)
        {
            var dbIntervencion = await _watchFactory.Intervenciones.FirstOrDefaultAsync(e => e.Id == id);
            if (dbIntervencion == null)
                return null;

            dbIntervencion.Descripcion = intervencion.Descripcion;
            dbIntervencion.TipoIntervencionID = intervencion.TipoIntervencionID;
            dbIntervencion.EstadoIntervencion = intervencion.EstadoIntervencion;
            dbIntervencion.TicketID= intervencion.TicketID;

            await _watchFactory.SaveChangesAsync();

            return await GetIntervenciones();
        }
    }
}
