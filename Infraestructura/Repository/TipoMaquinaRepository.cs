using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoMaquina;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class TipoMaquinaRepository : ITipoMaquinaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public TipoMaquinaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<TipoMaquina>> CreateTipoMaquina(CreateTipoMaquinaDto model)
        {
            await _watchFactory.TipoMaquinas.AddAsync(new TipoMaquina
            {
                Descripcion= model.Descripcion,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetAllTipoMaquinas();
        }

        public async Task<List<TipoMaquina>> DeleteTipoMaquina(int id)
        {
            var tipoMaquina = await GetTipoMaquinaById(id);
            _watchFactory.TipoMaquinas.Remove(tipoMaquina);
            await _watchFactory.SaveChangesAsync();

            return await GetAllTipoMaquinas();
        }

        public async Task<List<TipoMaquina>> GetAllDataFromTipoMaquinas(int skip, int take)
        {
            var tipos = await _watchFactory.TipoMaquinas
                .Include(tm => tm.Maquinas)
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return tipos;
        }

        public async Task<List<TipoMaquina>> GetAllTipoMaquinas()
        {
            return await _watchFactory.TipoMaquinas.ToListAsync();
        }

        public async Task<TipoMaquina> GetTipoMaquinaById(int id)
        {
            return await _watchFactory.TipoMaquinas.FirstOrDefaultAsync(tm => tm.Id == id);
        }

        public async Task<List<TipoMaquina>> UpdateTipoMaquina(int id, UpdateTipoMaquinaDto model)
        {
            var dbTipoMaquina = await _watchFactory.TipoMaquinas.FirstOrDefaultAsync(tm => tm.Id == id);

            dbTipoMaquina.Descripcion = model.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetAllTipoMaquinas();
        }
    }
}
