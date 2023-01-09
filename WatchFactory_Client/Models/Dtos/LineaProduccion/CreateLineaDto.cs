using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.LineaProduccion
{
    public class CreateLineaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int FabricaID { get; set; }
    }
}
