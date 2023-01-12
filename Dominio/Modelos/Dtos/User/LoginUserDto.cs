using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.User
{
    public class LoginUserDto
    {
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
    }
}
