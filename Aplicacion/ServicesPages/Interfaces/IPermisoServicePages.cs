using Dominio.Modelos.Dtos.Permiso;
using Dominio.Modelos.Usuarios;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IPermisoServicePages
    {
        IEnumerable<Permiso> Permisos { get; set; }
        IEnumerable<Rol> Roles { get; set; }

        Task GetAllPermisos();
        Task<Permiso> GetPermisoById(int id);
        Task CreatePermiso(CreatePermisoDto model);
        Task DeletePermisoById(int id);
        Task UpdatePermiso(int id, UpdatePermisoDto model);
        Task GetAllDataFromPermisos(int skip, int take);
        Task GetRoles();
    }
}
