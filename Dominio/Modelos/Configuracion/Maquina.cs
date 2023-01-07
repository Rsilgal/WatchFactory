using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class Maquina : EntidadBase<int>
    {
        public string Descripcion { get; set; } = string.Empty;
        public int LineaProduccionID { get; set; }
        public int TipoMaquinaID { get; set; }
        public LineaProduccion LineaProduccion { get; set; }
        public TipoMaquina TipoMaquina { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
