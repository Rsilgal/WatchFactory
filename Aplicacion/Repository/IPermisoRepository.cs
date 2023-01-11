using Dominio.Modelos.Dtos.Permiso;
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
        Task<List<Permiso>> CreatePermiso(CreatePermisoDto permiso);
        Task<List<Permiso>> UpdatePermiso(int id, UpdatePermisoDto permiso);
        Task<List<Permiso>> DeletePermiso(int id);
        Task<Permiso> GetPermisoById(int id);
        Task<List<Permiso>> GetAllDataFromPermisos(int skip, int take);
    }
}
