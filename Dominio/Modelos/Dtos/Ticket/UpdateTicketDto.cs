using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.Ticket
{
    public class UpdateTicketDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; } = string.Empty;
        [Required, Range(1, int.MaxValue)]
        public int MaquinaID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int CategoriaID { get; set; }
        public string UsuarioID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int UrgenciaID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int ZonaID { get; set; }
        [Required]
        public int EstadoID { get; set; }
    }
}
