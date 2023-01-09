using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.TipoIntervencion
{
    public class CreateTipoIntervencionDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
