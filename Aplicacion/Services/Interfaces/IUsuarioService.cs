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
        Task<List<Usuario>> GetUsuarios();
        Task<List<Usuario>> CreateUsuario(Usuario usuario);
        Task<List<Usuario>> UpdateUsuario(int id, Usuario usuario);
        Task<List<Usuario>> DeleteUsuario(int id);
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> GetUsuarioByCredentials(string Email);
    }
}
