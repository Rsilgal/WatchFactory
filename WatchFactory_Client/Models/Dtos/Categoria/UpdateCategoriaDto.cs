using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {

        [MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
