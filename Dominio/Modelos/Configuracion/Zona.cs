using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class Zona : EntidadBase<int>
    {
        /// <summary>
        /// Descripcion de la zona
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
    }
}
