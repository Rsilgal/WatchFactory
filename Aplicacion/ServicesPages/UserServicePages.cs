using System.Net.Http.Json;
using Aplicacion.Services.Pages.Interfaces;
using Dominio.Modelos.Dtos.User;

namespace Aplicacion.Services.Pages
{
    public class UserServicePages : IUserServicePages
    {
        private readonly HttpClient _http;
        private string token = string.Empty;

        public UserServicePages(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> login(LoginUserDto user)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", user);
            var token = await result.Content.ReadAsStringAsync();
            return token;
        }

        public async Task register(RegisterUserDto user)
        {
            var result = await _http.PostAsJsonAsync("api/usuario/register", user);
            var response = await result.Content.ReadFromJsonAsync<string>();
            token = response;
        }
    }
}
