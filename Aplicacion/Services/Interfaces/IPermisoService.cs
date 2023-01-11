using Dominio.Modelos.Dtos.Permiso;
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
        Task<List<Permiso>> GetPermisos();
        Task<List<Permiso>> CreatePermiso(CreatePermisoDto permiso);
        Task<List<Permiso>> GetAllDataFromPermisos(int skip, int take);
        Task<Permiso> GetPermisoById(int id);
        Task<List<Permiso>> UpdatePermiso(int id, UpdatePermisoDto model);
        Task<List<Permiso>> DeletePermiso(int id);
    }
}
