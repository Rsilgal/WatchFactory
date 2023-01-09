using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using WatchFactory_Client.Models.Dtos.Zona;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class ZonaService : IZonaService
    {
        private readonly HttpClient _http;

        public ZonaService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<Zona> Zonas { get; set; }

        public async Task CreateZona(CreateZonaDto model)
        {
            var result = await _http.PostAsJsonAsync("api/zona", model);
            await SetZona(result);
        }

        public async Task SetZona(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Zona>>();
            Zonas = response;
        }

        public async Task DeleteZona(int id)
        {
            var result = await _http.DeleteAsync($"api/zona/{id}");
            await SetZona(result);
        }

        public async Task GetAllZonas()
        {
            var result = await _http.GetFromJsonAsync<List<Zona>>("api/zona");
            if (result != null)
                Zonas= result;
        }

        public async Task<Zona> GetZonaById(int id)
        {
            var result = await _http.GetFromJsonAsync<Zona>($"api/zona/{id}");
            if (result != null)
                return result;
            throw new Exception("No se encontró Zona alguna.");
        }

        public async Task UpdateZona(int id, UpdateZonaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/zona/{id}", model);
            await SetZona(result);
        }
    }
}
