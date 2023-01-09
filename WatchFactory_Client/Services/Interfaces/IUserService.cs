using Dominio.Modelos;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IUserService
    {
        Task register(User user);
        Task login(User user);
    }
}
