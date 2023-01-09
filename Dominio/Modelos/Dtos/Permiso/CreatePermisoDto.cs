using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Permiso
{
    public class CreatePermisoDto
    {
        [Required, MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
