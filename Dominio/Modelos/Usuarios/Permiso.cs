using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Usuarios
{
    public class Permiso : EntidadBase<int>
    {
        public IList<PermisoRol> PermisoRols { get; set; }
    }
}
