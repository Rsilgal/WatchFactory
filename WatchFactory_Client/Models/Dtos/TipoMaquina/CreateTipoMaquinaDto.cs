using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.TipoMaquina
{
    public class CreateTipoMaquinaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
