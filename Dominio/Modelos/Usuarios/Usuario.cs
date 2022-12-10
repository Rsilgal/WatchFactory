using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Usuarios
{
    public class Usuario : EntidadBase<int>
    {
        public string Nombre { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public bool eliminado { get; set; } = false;
        public IList<RolUsuario> RolUsuarios { get; set; }
    }
}
