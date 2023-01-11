using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Zona;
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

        public async Task<List<Zona>> CreateZona(CreateZonaDto dto)
        {
            await _watchFactory.Zonas.AddAsync(new Zona
            {
                Descripcion = dto.Descripcion,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetZonas();
        }

        public async Task<List<Zona>> DeleteZona(int id)
        {
            var zona = await GetZonaById(id);
            _watchFactory.Zonas.Remove(zona);
            await _watchFactory.SaveChangesAsync();

            return await GetZonas();
        }

        public async Task<List<Zona>> GetAllDataFromZona(int skip, int take)
        {
            return await _watchFactory.Zonas
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task<Zona> GetZonaById(int id)
        {
            return await _watchFactory.Zonas.FirstOrDefaultAsync(z => z.Id == id);
        }

        public async Task<List<Zona>> GetZonas()
        {
            return await _watchFactory.Zonas.ToListAsync();
        }

        public async Task<List<Zona>> UpdateZona(int id, UpdateZonaDto dto)
        {
            var dbZona = await _watchFactory.Zonas.FirstOrDefaultAsync(z => z.Id == id);

            dbZona.Descripcion = dto.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetZonas();
        }
    }
}
