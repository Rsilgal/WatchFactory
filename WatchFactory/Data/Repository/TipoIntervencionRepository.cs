using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoIntervencion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchFactory.Data;

namespace WatchFactory.Data.Repository
{
    public class TipoIntervencionRepository : ITipoIntervencionRepository
    {
        private readonly ApplicationDbContext _watchFactory;

        public TipoIntervencionRepository(ApplicationDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<TipoIntervencion>> CreateTipoIntervencion(CreateTipoIntervencionDto model)
        {
            await _watchFactory.TipoIntervenciones.AddAsync(new TipoIntervencion
            {
                Descripcion= model.Descripcion,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetTipoIntervencion();
        }

        public async Task<List<TipoIntervencion>> DeleteTipoIntervencion(int id)
        {
            var tipo = await GetTipoIntervencionById(id);
            _watchFactory.TipoIntervenciones.Remove(tipo);
            await _watchFactory.SaveChangesAsync();

            return await GetTipoIntervencion();
        }

        public async Task<List<TipoIntervencion>> GetAllDataFromTipoIntervencion(int skip, int take)
        {
            var tipos = await _watchFactory.TipoIntervenciones
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return tipos;
        }

        public async Task<List<TipoIntervencion>> GetTipoIntervencion()
        {
            return await _watchFactory.TipoIntervenciones.ToListAsync();
        }

        public async Task<TipoIntervencion> GetTipoIntervencionById(int id)
        {
            return await _watchFactory.TipoIntervenciones.FirstOrDefaultAsync(ti => ti.Id == id);
        }

        public async Task<List<TipoIntervencion>> UpdateTipoIntervencion(int id, UpdateTipoIntervencionDto model)
        {
            var dbTipoIntervencion = await _watchFactory.TipoIntervenciones.FirstOrDefaultAsync(ti => ti.Id == id);

            dbTipoIntervencion.Descripcion = model.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetTipoIntervencion();
        }
    }
}
