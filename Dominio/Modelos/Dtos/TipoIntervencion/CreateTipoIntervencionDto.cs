using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.TipoIntervencion
{
    public class CreateTipoIntervencionDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
