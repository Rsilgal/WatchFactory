using System.Net.Http.Json;
using System.Reflection;
using WatchFactory_Client.Models.Dtos.Rol;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class RolService : IRolService
    {
        private readonly HttpClient _http;

        public RolService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<Rol> Roles { get; set; }
        public IEnumerable<Usuario> Usuarios { get; set; }

        public async Task CreateRol(CreateRolDto model)
        {
            var result = await _http.PostAsJsonAsync("api/rol", model);
            await SetRol(result);
        }

        private async Task SetRol(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Rol>>();
            Roles = response;
        }

        public async Task DeleteRol(int id)
        {
            var result = await _http.DeleteAsync($"api/rol");
            await SetRol(result);
        }

        public async Task GetAllRoles()
        {
            var result = await _http.GetFromJsonAsync<List<Rol>>("api/rol");
            if (result != null)
                Roles= result;
        }

        public async Task<Rol> GetRolById(int id)
        {
            var result = await _http.GetFromJsonAsync<Rol>($"api/rol{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ningun rol");
        }

        public async Task GetUsuarios()
        {
            var result = await _http.GetFromJsonAsync<List<Usuario>>("api/usuario");
            if (result != null)
                Usuarios = result;
        }

        public async Task UpdateRol(int id, UpdateRolDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/usuario/{id}", model);
            await SetRol(result);
        }
    }
}
