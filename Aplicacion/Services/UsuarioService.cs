using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario CreateUsuario(Usuario usuario)
        {
            _usuarioRepository.CreateUsuario(usuario);
            return usuario;
        }

        public Usuario DeleteUsuario(int id)
        {
            var usuario = _usuarioRepository.GetUsuario(id);
            return _usuarioRepository.DeleteUsuario(usuario);
        }

        public Usuario GetUsuario(int id)
        {
            return _usuarioRepository.GetUsuario(id);
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }

        public Usuario UpdateUsuario(int id, string Nombre, string Email, string Password, bool Eliminado, IList<RolUsuario> RolUsuario)
        {
            var usuario = _usuarioRepository.GetUsuario(id);
            usuario.Nombre= Nombre;
            usuario.Email= Email;
            //usuario= Password;
            usuario.Eliminado = Eliminado;
            usuario.RolUsuarios= RolUsuario;

            return _usuarioRepository.UpdateUsuario(usuario);
        }
    }
}
