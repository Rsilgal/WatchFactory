using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Usuarios
{
    public class RolUsuario : EntidadBase<int>
    {
        public int RolID { get; set; }
        public int UsuarioID { get; set; }
    }
}
