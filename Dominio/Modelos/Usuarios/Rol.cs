using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Usuarios
{
    public class Rol : EntidadBase<int>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool eliminado { get; set; } = false;

        public IEnumerable<Usuario> Usuarios { get; set; }
        public IEnumerable<Permiso> Permisos { get; set; }
    }
}
