using Dominio.Modelos.Dtos.Rol;
using Dominio.Modelos.Usuarios;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IRolServicePages
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
