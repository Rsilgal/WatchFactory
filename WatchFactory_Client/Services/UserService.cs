using System.Net.Http.Json;
using Dominio.Modelos.Dtos.User;
using Dominio.Modelos.Usuarios;
using WatchFactory_Client.Services.Interfaces;
using static System.Net.WebRequestMethods;

namespace WatchFactory_Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        private string token = string.Empty;

        public UserService(HttpClient http, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService _localStorage)
        {
            _http = http;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = _localStorage;
        }

        public async Task login(LoginUserDto user)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", user);
            var token = await result.Content.ReadAsStringAsync();
            await _localStorage.SetItemAsync("token", token);
            await _authenticationStateProvider.GetAuthenticationStateAsync();
        }

        public async Task register(RegisterUserDto user)
        {
            var result = await _http.PostAsJsonAsync("api/usuario/register", user);
            var response = await result.Content.ReadFromJsonAsync<string>();
            token = response;
        }
    }
}
