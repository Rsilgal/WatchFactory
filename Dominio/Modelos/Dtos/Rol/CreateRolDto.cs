using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Rol
{
    public class CreateRolDto
    {
        [Required, MinLength(1)]
        public string Name { get; set; }
        [Required, MinLength(1)]
        public string Description { get; set; }
    }
}
