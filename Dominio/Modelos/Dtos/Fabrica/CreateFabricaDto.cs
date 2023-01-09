using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Fabrica
{
    public class CreateFabricaDto
    {
        [MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; } = string.Empty;
    }
}
