using Dominio.Modelos.Dtos.User;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IUserServicePages
    {
        Task register(RegisterUserDto user);
        Task<string> login(LoginUserDto user);
    }
}
