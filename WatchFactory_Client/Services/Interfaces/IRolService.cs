using WatchFactory_Client.Models.Dtos.Rol;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IRolService
    {
        IEnumerable<Rol> Roles { get; set; }
        IEnumerable<Usuario> Usuarios { get; set; }

        Task GetAllRoles();
        Task GetRolById(int id);
        Task CreateRol(CreateRolDto model);
        Task DeleteRol(int id);
        Task UpdateRol(UpdateRolDto model);

        Task GetUsuarios();
    }
}
