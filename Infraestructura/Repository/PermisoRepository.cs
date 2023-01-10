using Aplicacion.Repository;
using Dominio.Modelos.Dtos.Permiso;
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

        public async Task<List<Permiso>> CreatePermiso(CreatePermisoDto model)
        {
            await _watchFactory.Permisos.AddAsync(new Permiso
            {
                Descripcion = model.Descripcion
            });
            await _watchFactory.SaveChangesAsync();

            return await GetPermisos();
        }

        public async Task<List<Permiso>> DeletePermiso(int id)
        {
            var permiso = await GetPermisoById(id);
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

        public async Task<List<Permiso>> UpdatePermiso(int id, UpdatePermisoDto model)
        {
            var dbPermiso = await _watchFactory.Permisos.FirstOrDefaultAsync(p => p.Id == id);

            dbPermiso.Descripcion = model.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetPermisos();
        }
    }
}
