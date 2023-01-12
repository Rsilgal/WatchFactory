using Dominio.Modelos.Dtos.User;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IUserService
    {
        Task register(RegisterUserDto user);
        Task login(LoginUserDto user);
    }
}
