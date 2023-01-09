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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public UsuarioRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Usuario>> CreateUsuario(Usuario usuario)
        {
            await _watchFactory.Usuarios.AddAsync(usuario);
            await _watchFactory.SaveChangesAsync();
            return await GetUsuarios();
        }

        public async Task<List<Usuario>> DeleteUsuario(Usuario usuario)
        {
            _watchFactory.Usuarios.Remove(usuario);
            await _watchFactory.SaveChangesAsync();
            return await GetUsuarios();
        }

        public Task<Usuario> GetUsuarioByCredentials(string email)
        {
            return _watchFactory.Usuarios.FirstOrDefaultAsync(e => e.Email == email && e.Eliminado == false);
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _watchFactory.Usuarios.
                Include(u => u.Roles).
                ThenInclude(r => r.Permisos).
                Where(u => u.Id == id).
                FirstOrDefaultAsync();
        }

        public async Task<List<Usuario>> GetUsuarioByPermiso(int permisoId)
        {
            var usuarios = await _watchFactory.Usuarios.
                Include(u => u.Roles).
                ThenInclude(r => r.Permisos).
                Where(u => u.Roles.Any(r => r.Permisos.Any(y => y.Id == permisoId))).
                ToListAsync();

            return usuarios;
        }

        public async Task<List<Usuario>> GetUsuarioByRol(int rolId)
        {
            var usuarios = await _watchFactory.Usuarios.
                Include(u => u.Roles).
                Where(u => u.Roles.Any(y => y.Id == rolId)).
                ToListAsync();

            return usuarios;
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await _watchFactory.Usuarios.ToListAsync();
        }

        public async Task<List<Usuario>> UpdateUsuario(int id, Usuario usuario)
        {
            var dbUsuario = await _watchFactory.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

            dbUsuario.Nombre = usuario.Nombre;
            dbUsuario.Eliminado= usuario.Eliminado;
            dbUsuario.Email= usuario.Email;
            
            await _watchFactory.SaveChangesAsync();
            return await GetUsuarios();
        }
    }
}
