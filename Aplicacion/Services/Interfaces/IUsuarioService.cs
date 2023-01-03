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
        Usuario CreateUsuario(string Nombre, string Email, string Password);
        Usuario UpdateUsuario(int id, string Nombre, string Email, string Password, bool Eliminado, IList<RolUsuario> RolUsuario);
        Usuario DeleteUsuario(int id);
        Usuario GetUsuario(int id);
    }
}
