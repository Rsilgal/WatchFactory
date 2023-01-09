using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.TipoIntervencion
{
    public class UpdateTipoIntervencionDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
