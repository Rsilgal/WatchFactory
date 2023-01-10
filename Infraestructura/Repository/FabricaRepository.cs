using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;
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

        public async Task<List<Fabrica>> CreateFabrica(CreateFabricaDto model)
        {
            await _watchFactory.Fabricas.AddAsync(new Fabrica
            {
                Descripcion= model.Descripcion,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetAllFabrica();
        }

        public async Task<List<Fabrica>> DeleteFabrica(int id)
        {
            var fabrica = await GetFabricaById(id);

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

        public async Task<List<Fabrica>> UpdateFabrica(int id, UpdateFabricaDto model)
        {
            var dbFabrica = await _watchFactory.Fabricas.Where(e => e.Id== id).FirstOrDefaultAsync();
            if (dbFabrica == null)
                return null;

            dbFabrica.Descripcion = model.Descripcion;

            return await GetAllFabrica();
        }
    }
}
