using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.User
{
    public class RegisterUserDto
    {
        [Required, MinLength(3)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
    }
}
