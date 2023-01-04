using WatchFactory_Client.Models;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IUserService
    {
        Task register(User user);
        Task login(User user);
    }
}
