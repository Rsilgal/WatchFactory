using Dominio.Modelos.Dtos.Rol;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IRolService
    {
        IEnumerable<Rol> Roles { get; set; }
        IEnumerable<Usuario> Usuarios { get; set; }

        Task GetAllRoles();
        Task<Rol> GetRolById(int id);
        Task CreateRol(CreateRolDto model);
        Task DeleteRol(int id);
        Task UpdateRol(int id, UpdateRolDto model);

        Task GetUsuarios();
        Task GetAllDataFromRol(int skip, int take);
    }
}
