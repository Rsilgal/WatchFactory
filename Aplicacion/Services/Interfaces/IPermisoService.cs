using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IPermisoService
    {
        List<Permiso> GetPermisos();
        Permiso CreatePermiso(Permiso permiso);
    }
}
