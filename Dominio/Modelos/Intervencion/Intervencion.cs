using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Intervencion
{
    public class Intervencion : EntidadBase<int>
    {
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        
        public int TicketID { get; set; }
        
        public int EstadoIntervencionID { get; set; }
        
        public int TipoIntervencionID { get; set; }
        
        public Ticket Ticket { get; set; }

        public EstadoIntervencion EstadoIntervencion { get; set; }

        public TipoIntervencion TipoIntervencion { get; set; }

    }
}
