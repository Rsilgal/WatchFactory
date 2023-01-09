using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Categoria
{
    public class CreateCategoriaDto
    {
        [MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
