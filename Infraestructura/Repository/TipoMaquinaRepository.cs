﻿using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
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

        public async Task<List<TipoMaquina>> CreateTipoMaquina(TipoMaquina tipoMaquina)
        {
            await _watchFactory.TipoMaquinas.AddAsync(tipoMaquina);
            await _watchFactory.SaveChangesAsync();

            return await GetAllTipoMaquinas();
        }

        public async Task<List<TipoMaquina>> DeleteTipoMaquina(TipoMaquina tipoMaquina)
        {
            _watchFactory.TipoMaquinas.Remove(tipoMaquina);
            await _watchFactory.SaveChangesAsync();

            return await GetAllTipoMaquinas();
        }

        public async Task<List<TipoMaquina>> GetAllTipoMaquinas()
        {
            return await _watchFactory.TipoMaquinas.ToListAsync();
        }

        public async Task<TipoMaquina> GetTipoMaquinaById(int id)
        {
            return await _watchFactory.TipoMaquinas.FirstOrDefaultAsync(tm => tm.Id == id);
        }

        public async Task<List<TipoMaquina>> UpdateTipoMaquina(int id, TipoMaquina tipoMaquina)
        {
            var dbTipoMaquina = await _watchFactory.TipoMaquinas.FirstOrDefaultAsync(tm => tm.Id == id);

            dbTipoMaquina.Descripcion = tipoMaquina.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetAllTipoMaquinas();
        }
    }
}
