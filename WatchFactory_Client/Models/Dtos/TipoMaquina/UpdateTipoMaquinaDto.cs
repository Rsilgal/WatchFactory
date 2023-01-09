using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.TipoMaquina
{
    public class UpdateTipoMaquinaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
