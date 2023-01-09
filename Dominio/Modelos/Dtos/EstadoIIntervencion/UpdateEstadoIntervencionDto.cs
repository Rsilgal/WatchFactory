using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.EstadoIIntervencion
{
    public class UpdateEstadoIntervencionDto
    {
        [MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
