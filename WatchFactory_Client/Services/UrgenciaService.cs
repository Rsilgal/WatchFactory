using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using Dominio.Modelos.Dtos.Urgencia;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class UrgenciaService : IUrgenciaService
    {
        private readonly HttpClient _http;

        public UrgenciaService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<Urgencia> Urgencias { get; set; }

        public async Task CreateUrgencia(CreateUrgenciaDto model)
        {
            var result = await _http.PostAsJsonAsync("api/urgencia", model);
            await SetUrgencia(result);
        }

        private async Task SetUrgencia(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Urgencia>>();
            Urgencias = response;
        }

        public async Task DeleteUrgencia(int id)
        {
            var result = await _http.DeleteAsync($"api/urgencia/{id}");
            await SetUrgencia(result);
        }

        public async Task GetAllUrgencias()
        {
            var result = await _http.GetFromJsonAsync<List<Urgencia>>("api/urgencia");
            if (result != null)
                Urgencias = result;
        }

        public async Task<Urgencia> GetUrgenciaById(int id)
        {
            var result = await _http.GetFromJsonAsync<Urgencia>($"api/urgencia/{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ninguna urgencia");
        }

        public async Task UpdateUrgencia(int id, UpdateUrgenciaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/urgencia/{id}", model);
            await SetUrgencia(result);
        }

        public async Task GetAllDataFromUrgencia(int skip, int take)
        {
            var result = await _http.GetFromJsonAsync<List<Urgencia>>($"api/urgencia/page/{skip}/{take}");
            if (result != null)
                Urgencias= result;
        }
    }
}
