using Aplicacion.Services;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        //public static Usuario usuario = new Usuario(); // Modificar para usar la base de datos, definido así para realizar pruebas.
        private readonly IConfiguration _configuration;
        private readonly IUsuarioService _usuarioService;

        public AuthController(IConfiguration configuration, IUsuarioService usuarioService)
        {
            _configuration = configuration;
            _usuarioService = usuarioService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<Usuario>> Register(UsuarioDto request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            Usuario usuario = new()
            {
                Nombre = request.Nombre,
                Email = request.Email,
                passwodrHash = passwordHash,
                passwordSalt = passwordSalt
            };

            _usuarioService.CreateUsuario(usuario);

            return Ok(usuario);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UsuarioDto request)
        {
            Usuario usuario = (from user in _usuarioService.GetUsuarios()
                               where user.Email == request.Email && user.Eliminado == false
                               select user).FirstOrDefault();

            if (usuario == null)
                return BadRequest("Usuario no encontrado.");

            if (!VerifyPasswordHash(request.Password, usuario.passwodrHash, usuario.passwordSalt))
                return BadRequest("Contraseña erronea.");

            string token = CreateToken(usuario);

            return Ok(token);
        }

        [NonAction]
        public string CreateToken(Usuario usuario)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.Email),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken (
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        [NonAction]
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        [NonAction]
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
