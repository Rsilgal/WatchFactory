using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class EstadoIntervencion : EntidadBase<int>
    {
        /// <summary>
        /// Descripcion del estado de la Intervención.
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
    }
}
