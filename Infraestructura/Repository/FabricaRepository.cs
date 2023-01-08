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
    public class FabricaRepository : IFabricaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public FabricaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Fabrica>> CreateFabrica(Fabrica fabrica)
        {
            await _watchFactory.Fabricas.AddAsync(fabrica);
            await _watchFactory.SaveChangesAsync();

            return await GetAllFabrica();
        }

        public async Task<List<Fabrica>> DeleteFabrica(Fabrica fabrica)
        {
            _watchFactory.Fabricas.Remove(fabrica);
            await _watchFactory.SaveChangesAsync();

            return await GetAllFabrica();
        }

        public async Task<List<Fabrica>> GetAllFabrica()
        {
            return await _watchFactory.Fabricas.ToListAsync();
        }

        public async Task<Fabrica> GetFabricaById(int id)
        {
            return await _watchFactory.Fabricas.Where(f => f.Id== id).FirstOrDefaultAsync();
        }

        public async Task<List<Fabrica>> UpdateFabrica(int id, Fabrica fabrica)
        {
            var dbFabrica = await _watchFactory.Fabricas.Where(e => e.Id== id).FirstOrDefaultAsync();
            if (dbFabrica == null)
                return null;

            dbFabrica.Descripcion = fabrica.Descripcion;

            return await GetAllFabrica();
        }
    }
}
