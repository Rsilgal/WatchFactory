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

        public async Task<List<Usuario>> CreateUsuario(Usuario usuario)
        {
            return await _usuarioRepository.CreateUsuario(usuario);
            
        }

        public async Task<List<Usuario>> DeleteUsuario(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioById(id);
            return await _usuarioRepository.DeleteUsuario(usuario);
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _usuarioRepository.GetUsuarioById(id);
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await _usuarioRepository.GetUsuarios();
        }

        public async Task<List<Usuario>> UpdateUsuario(int id, Usuario usuario)
        {
              return await _usuarioRepository.UpdateUsuario(id, usuario);
        }

        public async Task<Usuario> GetUsuarioByCredentials(string Email)
        {
            return await _usuarioRepository.GetUsuarioByCredentials(Email);
        }
    }
}
