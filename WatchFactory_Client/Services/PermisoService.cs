using System.Net.Http.Json;
using Dominio.Modelos.Dtos.Permiso;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class PermisoService : IPermisoService
    {
        private readonly HttpClient _http;

        public PermisoService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<Permiso> Permisos { get; set; }
        public IEnumerable<Rol> Roles { get; set; }

        public async Task CreatePermiso(CreatePermisoDto model)
        {
            var result = await _http.PostAsJsonAsync("api/permiso", model);
            await SetPermiso(result);
        }

        private async Task SetPermiso(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Permiso>>();
            Permisos = response;
        }

        public async Task DeletePermisoById(int id)
        {
            var result = await _http.DeleteAsync($"api/permiso/{id}");
            await SetPermiso(result);
        }

        public async Task GetAllPermisos()
        {
            var result = await _http.GetFromJsonAsync<List<Permiso>>("api/permiso");
            if (result != null)
                Permisos = result;
        }

        public async Task<Permiso> GetPermisoById(int id)
        {
            var result = await _http.GetFromJsonAsync<Permiso>($"api/permiso/{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ningun permiso");
        }

        public async Task UpdatePermiso(int id, UpdatePermisoDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/permiso/{id}", model);
            await SetPermiso(result);
        }

        public async Task GetAllDataFromPermisos(int skip, int take)
        {
            var result = await _http.GetFromJsonAsync<List<Permiso>>($"api/permiso/page/{skip}/{take}");
            if (result != null)
                Permisos= result;
        }

        public async Task GetRoles()
        {
            var result = await _http.GetFromJsonAsync<List<Rol>>("api/roles");
            if (result != null)
                Roles = result;
        }
    }
}
