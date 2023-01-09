using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Ticket
{
    public class CreateTicketDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int MaquinaID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int CategoriaID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int UsuarioID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int UrgenciaID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int ZonaID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public string EstadoID { get; set; }
    }
}
