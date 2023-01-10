using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.LineaProduccion;
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

        public async Task<List<LineaProduccion>> CreateLineaProduccion(CreateLineaDto model)
        {
            await _watchFactory.Lineas.AddAsync(new LineaProduccion
            {
                Descripcion= model.Descripcion,
                FabricaID= model.FabricaID,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetAllLineasProduccion();
        }

        public async Task<List<LineaProduccion>> DeleteLineaProduccion(int id)
        {
            var lineaProduccion = await GetLineaProduccionById(id);
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

        public async Task<List<LineaProduccion>> UpdateLineaProduccion(int id, UpdateLineaDto model)
        {
            var dbLinea = await _watchFactory.Lineas.FirstOrDefaultAsync(l => l.Id == id);

            dbLinea.Descripcion = model.Descripcion;
            dbLinea.FabricaID = model.FabricaID;

            await _watchFactory.SaveChangesAsync();

            return await GetAllLineasProduccion();
        }
    }
}
