using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
    }
}
