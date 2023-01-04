using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models
{
    public class User
    {
        public string Name { get; set; }
        [Required, MinLength(3, ErrorMessage = "Mensaje de error"), MaxLength(15)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
