using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Urgencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class UrgenciaRepository : IUrgenciaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public UrgenciaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Urgencia>> CreateUrgencia(CreateUrgenciaDto dto)
        {
            await _watchFactory.AddAsync(new Urgencia
            {
                Descripcion= dto.Descripcion,
            });
            await _watchFactory.SaveChangesAsync();

            return await GetUrgencias();
        }

        public async Task<List<Urgencia>> DeleteUrgencia(int id)
        {
            var urgencia = await GetUrgenciaById(id);
            _watchFactory.Urgencias.Remove(urgencia);
            await _watchFactory.SaveChangesAsync(); 
            
            return await GetUrgencias();
        }

        public async Task<Urgencia> GetUrgenciaById(int id)
        {
            return await _watchFactory.Urgencias.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Urgencia>> GetUrgencias()
        {
            return await _watchFactory.Urgencias.ToListAsync();
        }

        public async Task<List<Urgencia>> UpdateUrgencia(int id, UpdateUrgenciaDto to)
        {
            var dbUrgencia = await _watchFactory.Urgencias.FirstOrDefaultAsync(u => u.Id == id);

            dbUrgencia.Descripcion = to.Descripcion;

            return await GetUrgencias();
        }
    }
}
