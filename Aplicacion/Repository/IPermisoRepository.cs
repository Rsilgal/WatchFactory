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
        Task<List<Permiso>> GetPermisos();
        Task<List<Permiso>> CreatePermiso(Permiso permiso);
        Task<List<Permiso>> UpdatePermiso(int id, Permiso permiso);
        Task<List<Permiso>> DeletePermiso(Permiso permiso);
        Task<Permiso> GetPermisoById(int id);
    }
}
