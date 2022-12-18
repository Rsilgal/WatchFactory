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
        public int TicketID { get; set; }
        public int EstadoIntervencionID { get; set; }
        public int TipoIntervencionID { get; set; }

        [ForeignKey("Ticket")]
        public virtual Ticket Ticket { get; set; }

        [ForeignKey("EstadoIntervencionID")]
        public virtual EstadoIntervencion EstadoIntervencion { get; set; }

        [ForeignKey("TipoIntervencionID")]
        public virtual TipoIntervencion TipoIntervencion { get; set; }

        public Intervencion(string descripcion, int ticketID, int estadoIntervencionID, int tipoIntervencionID)
        {
            Descripcion = descripcion;
            TicketID = ticketID;
            EstadoIntervencionID = estadoIntervencionID;
            TipoIntervencionID = tipoIntervencionID;
        }
    }
}
