using WatchFactory_Client.Models.Dtos.Usuario;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> Usuarios { get; set; }
        IEnumerable<Rol> Roles { get; set; }
        IEnumerable<Permiso> Permisos { get; set; }

        Task GetAllUsuarios();
        Task GetUsuarioById(int id);
        Task CreateUsuario(CreateUsusarioDto model);
        Task DeleteUsuario(int id);
        Task UpdateUsuario(UpdateUsusarioDto model);

        Task GetRoles();
        Task GetPermisos();

    }
}
