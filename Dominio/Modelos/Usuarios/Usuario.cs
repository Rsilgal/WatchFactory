using Dominio.Modelos.Nucleo;
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
        public string Email { get; set; } = string.Empty;
        public byte[] passwodrHash { get; set; }
        public byte[] passwordSalt { get; set; }
        public bool Eliminado { get; set; } = false;

        public IEnumerable<Ticket> Tickets { get; set; }

        public IEnumerable<Rol> Roles { get; set; }
    }
}
