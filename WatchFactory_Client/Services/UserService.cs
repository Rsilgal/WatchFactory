using System.Net.Http.Json;
using Dominio.Modelos;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;
        private string token = string.Empty;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public Task login(User user)
        {
            throw new NotImplementedException();
        }

        public async Task register(User user)
        {
            var result = await _http.PostAsJsonAsync("api/usuario/register", user);
            var response = await result.Content.ReadFromJsonAsync<string>();
            token = response;
        }
    }
}
