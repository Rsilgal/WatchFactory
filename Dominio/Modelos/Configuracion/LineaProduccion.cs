using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Configuracion
{
    public class LineaProduccion : EntidadBase<int>
    {
        /// <summary>
        /// Define la descipción de la una linea de producción
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
        public int FabricaID { get; set; }
        
        public Fabrica Fabrica { get; set; }
        public IEnumerable<Maquina> Maquinas { get; set; }
    }
}
