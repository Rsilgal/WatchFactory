using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Confiiguracion
{
    public class Maquina
    {
        public string Descripcion { get; set; } = string.Empty;
        public int LineaProduccionID { get; set; }
        public int TipoMaquinaID { get; set; }
        [ForeignKey("LineaProduccionID")]
        public virtual LineaProduccion LineaProduccion { get; set; }
        [ForeignKey("TipoMaquinaID")]
        public virtual TipoMaquina TipoMaquina { get; set; }
    }
}
