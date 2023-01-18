using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.TipoMaquina
{
    public class CreateTipoMaquinaDto
    {
        [Required, MinLength(3)]
        public string Descripcion { get; set; }
    }
}
