using Dominio.Modelos.Dtos.Permiso;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IPermisoService
    {
        IEnumerable<Permiso> Permisos { get; set; }
        IEnumerable<Rol> Roles { get; set; }

        Task GetAllPermisos();
        Task<Permiso> GetPermisoById(int id);
        Task CreatePermiso(CreatePermisoDto model);
        Task DeletePermisoById(int id);
        Task UpdatePermiso(int id, UpdatePermisoDto model);
    }
}
