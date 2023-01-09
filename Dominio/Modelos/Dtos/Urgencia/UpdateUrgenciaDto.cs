using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Urgencia
{
    public class UpdateUrgenciaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
