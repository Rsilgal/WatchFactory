using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Intervencion
{
    public class CreateIntervencionDto
    {
        [MinLength(1)]
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Range(0, int.MaxValue)]
        public int TicketId { get; set; }
        [Range(0, int.MaxValue)]
        public int EstadoId { get; set; }
        [Range(0, int.MaxValue)]
        public int TipoId { get; set;}
    }
}
