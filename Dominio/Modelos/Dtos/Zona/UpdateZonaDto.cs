using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Zona
{
    public class UpdateZonaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
