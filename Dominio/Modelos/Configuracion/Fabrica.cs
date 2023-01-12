using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class Fabrica: EntidadBase<int>
    {
        /// <summary>
        /// Obtención y escritura del atributo Descirpcion
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
        //public IEnumerable<LineaProduccion> Lineas { get;}
    }
}
