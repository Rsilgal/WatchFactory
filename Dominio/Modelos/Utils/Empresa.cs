using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Utils
{
    public class Empresa : EntidadBase<int>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
        public string Eslogan { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
    }
}
