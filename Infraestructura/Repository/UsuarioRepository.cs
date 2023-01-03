using Aplicacion.Repository;
using Dominio.Modelos.Usuarios;
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

        public Usuario CreateUsuario(Usuario usuario)
        {
            _watchFactory.Usuarios.Add(usuario);
            _watchFactory.SaveChanges();
            return usuario;
        }

        public Usuario DeleteUsuario(Usuario usuario)
        {
            _watchFactory.Usuarios.Remove(usuario);
            _watchFactory.SaveChanges();
            return usuario;
        }

        public Usuario GetUsuario(int id)
        {
            return _watchFactory.Usuarios.FirstOrDefault(e => e.Id == id);
        }

        public List<Usuario> GetUsuarios()
        {
            return _watchFactory.Usuarios.ToList();
        }

        public Usuario UpdateUsuario(Usuario usuario)
        {
            _watchFactory.Usuarios.Update(usuario);
            _watchFactory.SaveChanges();
            return usuario;
        }
    }
}
