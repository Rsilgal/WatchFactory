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
    public class RolRepository : IRolRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public RolRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Rol>> CreateRol(Rol rol)
        {
            await _watchFactory.Roles.AddAsync(rol);
            await _watchFactory.SaveChangesAsync();

            return await GetRols();
        }

        public async Task<List<Rol>> DeleteRol(Rol rol)
        {
            _watchFactory.Roles.Remove(rol);
            await _watchFactory.SaveChangesAsync();
            
            return await GetRols();
        }

        public async Task<Rol> GetRolById(int id)
        {
            return await _watchFactory.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Rol>> GetRols()
        {
            return await _watchFactory.Roles.ToListAsync();
        }

        public async Task<List<Rol>> UpdateRol(int id, Rol rol)
        {
            var dbRol = await _watchFactory.Roles.FirstOrDefaultAsync(r => r.Id == id);

            dbRol.Descripcion = rol.Descripcion;
            dbRol.Nombre = rol.Nombre;
            dbRol.eliminado = rol.eliminado;

            await _watchFactory.SaveChangesAsync();

            return await GetRols();

        }
    }
}
