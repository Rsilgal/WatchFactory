using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Utils
{
    public class Estadistica : EntidadBase<int>
    {
        //public DateAndTime Fecha { get; set; }
        public int TicketsCerrados { get; set; }
        public int TicketsPendientes { get; set; }
        public int TicketsTotales { get; set; }
    }
}
