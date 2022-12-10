using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class Urgencia : EntidadBase<int>
    {
        /// <summary>
        /// Descicpción de la Urgencia.
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
    }
}
