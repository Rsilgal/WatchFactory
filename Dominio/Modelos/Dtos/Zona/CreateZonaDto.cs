using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Zona
{
    public class CreateZonaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
