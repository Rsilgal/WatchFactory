using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class ZonaRepository : IZonaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public ZonaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Zona>> CreateZona(Zona zona)
        {
            await _watchFactory.Zonas.AddAsync(zona);
            await _watchFactory.SaveChangesAsync();

            return await GetZonas();
        }

        public async Task<List<Zona>> DeleteZona(Zona zona)
        {
            _watchFactory.Zonas.Remove(zona);
            await _watchFactory.SaveChangesAsync();

            return await GetZonas();
        }

        public async Task<Zona> GetZonaById(int id)
        {
            return await _watchFactory.Zonas.FirstOrDefaultAsync(z => z.Id == id);
        }

        public async Task<List<Zona>> GetZonas()
        {
            return await _watchFactory.Zonas.ToListAsync();
        }

        public async Task<List<Zona>> UpdateZona(int id, Zona zona)
        {
            var dbZona = await _watchFactory.Zonas.FirstOrDefaultAsync(z => z.Id == id);

            dbZona.Descripcion = zona.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetZonas();
        }
    }
}
