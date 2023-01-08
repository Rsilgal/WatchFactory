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
    public class UrgenciaRepository : IUrgenciaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public UrgenciaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Urgencia>> CreateUrgencia(Urgencia urgencia)
        {
            await _watchFactory.AddAsync(urgencia);
            await _watchFactory.SaveChangesAsync();

            return await GetUrgencias();
        }

        public async Task<List<Urgencia>> DeleteUrgencia(Urgencia urgencia)
        {
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

        public async Task<List<Urgencia>> UpdateUrgencia(int id, Urgencia urgencia)
        {
            var dbUrgencia = await _watchFactory.Urgencias.FirstOrDefaultAsync(u => u.Id == id);

            dbUrgencia.Descripcion = urgencia.Descripcion;

            return await GetUrgencias();
        }
    }
}
