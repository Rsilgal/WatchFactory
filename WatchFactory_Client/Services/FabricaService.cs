using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using Dominio.Modelos.Dtos.Fabrica;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class FabricaService : IFabricaService
    {
        private readonly HttpClient _http;

        public FabricaService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<Fabrica> Fabricas { get; set; }

        public async Task CreateFabrica(CreateFabricaDto model)
        {
            var result = await _http.PostAsJsonAsync("api/fabrica", model);
            await SetFabrica(result);
        }

        private async Task SetFabrica(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Fabrica>>();
            Fabricas = response;
        }

        public async Task DeleteFabricaById(int id)
        {
            var result = await _http.DeleteAsync($"api/fabrica/{id}");
            await SetFabrica(result);
        }

        public async Task GetAllFabrica()
        {
            var result = await _http.GetFromJsonAsync<List<Fabrica>>("api/fabrica");
            if (result != null)
                Fabricas = result;
        }

        public async Task<Fabrica> GetFabricaById(int id)
        {
            var result = await _http.GetFromJsonAsync<Fabrica>($"api/fabrica/{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ninguna fabrica.");
        }

        public async Task UpdateFabrica(int id, UpdateFabricaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/fabrica/{id}", model);
            await SetFabrica(result);
        }
    }
}
