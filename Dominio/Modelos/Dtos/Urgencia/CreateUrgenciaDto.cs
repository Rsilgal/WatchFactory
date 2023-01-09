using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Urgencia
{
    public class CreateUrgenciaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
