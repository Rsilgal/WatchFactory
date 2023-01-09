using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Ticket
{
    public class UpdateTicketDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; } = string.Empty;
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
