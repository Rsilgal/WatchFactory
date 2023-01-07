using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Utils
{
    public class Reporte : EntidadBase<int>
    {
        public Ticket Ticket { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaReporte { get; set; }
    }
}
