using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos
{
    public class User
    {
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
    }
}
