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
    public class LineaProduccionRepository : ILineaProduccionRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;
        public LineaProduccionRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory= watchFactory;
        }

        public async Task<List<LineaProduccion>> CreateLineaProduccion(LineaProduccion lineaProduccion)
        {
            await _watchFactory.Lineas.AddAsync(lineaProduccion);
            await _watchFactory.SaveChangesAsync();

            return await GetAllLineasProduccion();
        }

        public async Task<List<LineaProduccion>> DeleteLineaProduccion(LineaProduccion lineaProduccion)
        {
            _watchFactory.Lineas.Remove(lineaProduccion);
            await _watchFactory.SaveChangesAsync();

            return await GetAllLineasProduccion();
        }

        public async Task<List<LineaProduccion>> GetAllLineasProduccion()
        {
            return await _watchFactory.Lineas.ToListAsync();
        }

        public async Task<List<LineaProduccion>> GetLineaProduccionByFabrica(int fabricaId)
        {
            var lineas = await _watchFactory.Lineas.
                Where(l => l.FabricaID == fabricaId).ToListAsync();

            return lineas;
        }

        public async Task<LineaProduccion> GetLineaProduccionById(int id)
        {
            return await _watchFactory.Lineas.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<List<LineaProduccion>> UpdateLineaProduccion(int id, LineaProduccion lineaProduccion)
        {
            var dbLinea = await _watchFactory.Lineas.FirstOrDefaultAsync(l => l.Id == id);

            dbLinea.Descripcion = lineaProduccion.Descripcion;
            dbLinea.FabricaID = lineaProduccion.FabricaID;

            await _watchFactory.SaveChangesAsync();

            return await GetAllLineasProduccion();
        }
    }
}
