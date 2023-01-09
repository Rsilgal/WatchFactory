using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.EstadoIIntervencion
{
    public class CreateEstadoIntervencionDto
    {
        [MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
