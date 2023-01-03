using Infraestructura;

namespace WebApi.Services
{
    public class UserService : IUserService
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public UserService(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public bool IsUser(string email, string pass)
        {
            return _watchFactory.Usuarios.Where(e => e.Email == email && e.Password == pass && e.Eliminado == false).Count() > 0;
        }
    }
}
