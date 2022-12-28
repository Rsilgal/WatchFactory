using Dominio.Modelos;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Utils
{
    public class Notificacion : EntidadBase<int>
    {
        //public Ticket Ticket { get; set; }
        public Intervencion.Intervencion Intervencion { get; set; }
        public Zona Zona { get; set; }
    }
}
