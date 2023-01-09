using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Fabrica
{
    public class CreateFabricaDto
    {
        [MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; } = string.Empty;
    }
}
