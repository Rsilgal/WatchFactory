using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IPermisoRepository
    {
        List<Permiso> GetPermisos();
        Permiso CreatePermiso(Permiso permiso);
    }
}
