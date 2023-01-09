using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos.Dtos.LineaProduccion
{
    public class UpdateLineaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int FabricaID { get; set; }
    }
}
