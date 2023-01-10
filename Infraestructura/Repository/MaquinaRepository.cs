using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Maquina;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class MaquinaRepository : IMaquinaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;
        public MaquinaRepository(WatchFactoryDbContext watchFactory) 
        {
            _watchFactory= watchFactory;
        }

        public async Task<List<Maquina>> CreateMaquina(CreateMaquinaDto model)
        {
            await _watchFactory.Maquinas.AddAsync(new Maquina
            {
                Descripcion = model.Descripcion,
                LineaProduccionID = model.LineaProduccionID,
                TipoMaquinaID = model.TipoMaquinaID
            });
            await _watchFactory.SaveChangesAsync();

            return await GetAllMaquinas();
        }

        public async Task<List<Maquina>> DeleteMaquina(int id)
        {
            var maquina = await GetMaquinaById(id);
            _watchFactory.Maquinas.Remove(maquina);
            await _watchFactory.SaveChangesAsync();

            return await GetAllMaquinas();
        }

        public async Task<List<Maquina>> GetAllMaquinas()
        {
            return await _watchFactory.Maquinas.ToListAsync();
        }

        public async Task<Maquina> GetMaquinaById(int id)
        {
            return await _watchFactory.Maquinas.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<Maquina>> GetMaquinasByFabrica(int fabricaId)
        {
            var maquinas = await _watchFactory.Maquinas.
                Include(m => m.LineaProduccion).
                ThenInclude(l => l.Fabrica).
                Where(m => m.LineaProduccion.Fabrica.Id == fabricaId)
                .ToListAsync();

            return maquinas;
        }

        public async Task<List<Maquina>> GetMaquinasByLinea(int lineaId)
        {
            var maquinas = await _watchFactory.Maquinas.
                Include(m => m.LineaProduccion).
                Where(m => m.LineaProduccion.Id== lineaId).
                ToListAsync();

            return maquinas;
        }

        public async Task<List<Maquina>> GetMaquinasByTipoMaquina(int tipoMaquinaId)
        {
            var maquinas = await _watchFactory.Maquinas.
                Include(m => m.TipoMaquina).
                Where(m => m.TipoMaquina.Id == tipoMaquinaId).
                ToListAsync();

            return maquinas;
        }

        public async Task<List<Maquina>> UpdateMaquina(int id, UpdateMaquinaDto model)
        {
            var dbMaquina = await _watchFactory.Maquinas.FirstOrDefaultAsync(m => m.Id ==id);

            dbMaquina.Descripcion = model.Descripcion;
            dbMaquina.TipoMaquinaID = model.TipoMaquinaID;
            dbMaquina.LineaProduccionID = model.LineaProduccionID;

            await _watchFactory.SaveChangesAsync();

            return await GetAllMaquinas();
        }
    }
}
