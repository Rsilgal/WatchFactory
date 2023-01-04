using Aplicacion.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UserController(IUsuarioService usuarioService) 
        {
            _usuarioService= usuarioService;
        }

        [HttpGet]
        public ActionResult Get() 
        {
            var usuariosFromService = _usuarioService.GetUsuarios();
            if (usuariosFromService == null) return NotFound();
            return Ok(usuariosFromService);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var usuarioFromService = _usuarioService.GetUsuario(id);
            if (usuarioFromService== null) return NotFound();
            return Ok(usuarioFromService);
        }

        //[HttpPost]
        //public ActionResult Post(usua) 
        //{
        //    var newUsuarioFromService = _usuarioService.CreateUsuario(Nombre, Email, Password);
        //    if (newUsuarioFromService== null) return NotFound();
        //    return Ok(newUsuarioFromService);
        //}

        [HttpPut("{id}")]
        public ActionResult Put(int id, string Nombre, string Email, string Password, bool Eliminado)
        {
            var updatedUsuarioFromService = _usuarioService.UpdateUsuario(id, Nombre, Email, Password, Eliminado, null);
            if (updatedUsuarioFromService== null) return NotFound();
            return Ok(updatedUsuarioFromService);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            var deletedUsuarioFromService = _usuarioService.DeleteUsuario(id);
            if (deletedUsuarioFromService== null) return NotFound();
            return Ok(deletedUsuarioFromService);
        }
    }
}
