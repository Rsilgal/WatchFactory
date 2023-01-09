using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.TipoMaquina
{
    public class CreateTipoMaquinaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
