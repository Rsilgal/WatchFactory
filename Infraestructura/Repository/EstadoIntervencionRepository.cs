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
    public class EstadoIntervencionRepository : IEstadoIntervencionRepository
    {
        public readonly WatchFactoryDbContext _watchFactory;
        public EstadoIntervencionRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory= watchFactory;
        }

        public async Task<List<EstadoIntervencion>> CreateEstadoIntervencion(EstadoIntervencion estado)
        {
            await _watchFactory.EstadoIntervenciones.AddAsync(estado);
            await _watchFactory.SaveChangesAsync();

            return await GetEstadoIntervencion();
        }

        public async Task<List<EstadoIntervencion>> DeleteEstadoIntervencion(EstadoIntervencion estado)
        {
            _watchFactory.EstadoIntervenciones.Remove(estado);
            await _watchFactory.SaveChangesAsync();

            return await GetEstadoIntervencion();
        }

        public async Task<List<EstadoIntervencion>> GetEstadoIntervencion()
        {
            return await _watchFactory.EstadoIntervenciones.ToListAsync();
        }

        public async Task<EstadoIntervencion> GetEstadoIntervencionById(int id)
        {
            return await _watchFactory.EstadoIntervenciones.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<EstadoIntervencion>> UpdateEstadoIntervencion(int id, EstadoIntervencion estado)
        {
            var dbEstado = await _watchFactory.EstadoIntervenciones.FirstOrDefaultAsync(e => e.Id == id);

            dbEstado.Descripcion = estado.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetEstadoIntervencion();
        }
    }
}
