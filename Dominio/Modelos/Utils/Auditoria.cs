using Dominio.Modelos.Usuarios;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Utils
{
    public class Auditoria : EntidadBase<int>
    {
        //public DateAndTime Fecha { get; set; }
        public Usuario Usuario { get; set; }
        public string Accion { get; set; }
    }
}
