using Aplicacion.Repository;
using Dominio.Modelos.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class PermisoRepository : IPermisoRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public PermisoRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Permiso>> CreatePermiso(Permiso permiso)
        {
            await _watchFactory.Permisos.AddAsync(permiso);
            await _watchFactory.SaveChangesAsync();

            return await GetPermisos();
        }

        public async Task<List<Permiso>> DeletePermiso(Permiso permiso)
        {
            _watchFactory.Permisos.Remove(permiso);
            await _watchFactory.SaveChangesAsync();

            return await GetPermisos();
        }

        public async Task<Permiso> GetPermisoById(int id)
        {
            return await _watchFactory.Permisos.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Permiso>> GetPermisos()
        {
            return await _watchFactory.Permisos.ToListAsync();
        }

        public async Task<List<Permiso>> UpdatePermiso(int id, Permiso permiso)
        {
            var dbPermiso = await _watchFactory.Permisos.FirstOrDefaultAsync(p => p.Id == id);

            dbPermiso.Descripcion = permiso.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetPermisos();
        }
    }
}
