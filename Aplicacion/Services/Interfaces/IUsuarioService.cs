using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuarios();
        Usuario CreateUsuario(Usuario usuario);
        Usuario UpdateUsuario(int id, Usuario usuario);
        Usuario DeleteUsuario(int id);
        Usuario GetUsuario(int id);
    }
}
