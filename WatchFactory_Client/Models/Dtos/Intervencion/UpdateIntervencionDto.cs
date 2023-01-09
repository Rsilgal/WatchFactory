using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Intervencion
{
    public class UpdateIntervencionDto
    {
        [MinLength(1)]
        public string Descripcion { get; set; }
        [Range(0, int.MaxValue)]
        public int EstadoId { get; set; }
        [Range(0, int.MaxValue)]
        public int TipoId { get; set; }
    }
}
