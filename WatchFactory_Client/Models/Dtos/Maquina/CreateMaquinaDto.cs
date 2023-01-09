using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Maquina
{
    public class CreateMaquinaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int LineaProduccionID { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int TipoMaquinaID { get; set; }
    }
}
