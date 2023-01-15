using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.EstadoIIntervencion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchFactory.Data;

namespace WatchFactory.Data.Repository
{
    public class EstadoIntervencionRepository : IEstadoIntervencionRepository
    {
        public readonly ApplicationDbContext _watchFactory;
        public EstadoIntervencionRepository(ApplicationDbContext watchFactory)
        {
            _watchFactory= watchFactory;
        }

        public async Task<List<EstadoIntervencion>> CreateEstadoIntervencion(CreateEstadoIntervencionDto model)
        {
            await _watchFactory.EstadoIntervenciones.AddAsync(new EstadoIntervencion
            {
                Descripcion= model.Descripcion,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetEstadoIntervencion();
        }

        public async Task<List<EstadoIntervencion>> DeleteEstadoIntervencion(int id)
        {
            var estado = await GetEstadoIntervencionById(id);
            _watchFactory.EstadoIntervenciones.Remove(estado);
            await _watchFactory.SaveChangesAsync();

            return await GetEstadoIntervencion();
        }

        public async Task<List<EstadoIntervencion>> GetEstadoIntervencion()
        {
            return await _watchFactory.EstadoIntervenciones.ToListAsync();
        }

        public async Task<EstadoIntervencion> GetEstadoIntervencionById(int id)
        {
            return await _watchFactory.EstadoIntervenciones.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<EstadoIntervencion>> UpdateEstadoIntervencion(int id, UpdateEstadoIntervencionDto model)
        {
            var dbEstado = await _watchFactory.EstadoIntervenciones.FirstOrDefaultAsync(e => e.Id == id);

            dbEstado.Descripcion = model.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetEstadoIntervencion();
        }
    }
}
