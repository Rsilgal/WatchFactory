using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class TipoIntervencion : EntidadBase<int>
    {
        /// <summary>
        /// Descipción del tipo de intervención.
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
    }
}
