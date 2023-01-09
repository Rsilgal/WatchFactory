using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.TipoIntervencion
{
    public class UpdateTipoIntervencionDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
