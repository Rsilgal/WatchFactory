using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Zona
{
    public class CreateZonaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
