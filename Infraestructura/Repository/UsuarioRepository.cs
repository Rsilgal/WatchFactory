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
            throw new NotImplementedException();
        }

        public List<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
