using WatchFactory_Client.Models.Dtos.Permiso;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IPermisoService
    {
        IEnumerable<Permiso> Permisos { get; set; }
        IEnumerable<Rol> Roles { get; set; }

        Task GetAllPermisos();
        Task GetPermisoById(int id);
        Task CreatePermiso(CreatePermisoDto model);
        Task DeletePermisoById(int id);
        Task UpdatePermiso(UpdatePermisoDto model);
    }
}
