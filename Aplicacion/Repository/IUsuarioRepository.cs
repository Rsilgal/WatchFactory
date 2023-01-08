using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetUsuarios();
        Task<List<Usuario>> CreateUsuario(Usuario usuario);
        Task<List<Usuario>> UpdateUsuario(int id, Usuario usuario);
        Task<List<Usuario>> DeleteUsuario(Usuario usuario);
        Task<Usuario> GetUsuarioById(int id);
        Task<List<Usuario>> GetUsuarioByRol(int rolId);
        Task<List<Usuario>> GetUsuarioByPermiso(int permisoId);
    }
}
