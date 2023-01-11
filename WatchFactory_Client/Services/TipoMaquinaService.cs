using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using System.Reflection;
using Dominio.Modelos.Dtos.TipoMaquina;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class TipoMaquinaService : ITipoMaquinaService
    {
        private readonly HttpClient _http;

        public TipoMaquinaService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<TipoMaquina> TiposMaquinas { get; set; }

        public async Task CreateTipoMaquina(CreateTipoMaquinaDto model)
        {
            var result = await _http.PostAsJsonAsync("api/tipomaquina", model);
            await SetTipMaquina(result);
        }

        private async Task SetTipMaquina(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<TipoMaquina>>();
            TiposMaquinas = response;
        }

        public async Task DeleteTipoMaquina(int id)
        {
            var result = await _http.DeleteAsync("api/tipomaquina");
            await SetTipMaquina(result);
        }

        public async Task<TipoMaquina> GetTipoMaquinaById(int id)
        {
            var result = await _http.GetFromJsonAsync<TipoMaquina>($"api/tipomaquina/{id}");
            if (result != null)
                return result;
            throw new Exception("No se encontro el tipo de maquina");
        }

        public async Task GetTiposMaquinas()
        {
            var result = await _http.GetFromJsonAsync<List<TipoMaquina>>("api/tipomaquina");
            if (result != null)
                TiposMaquinas = result;
        }

        public async Task UpdateTipoMaquina(int id, UpdateTipoMaquinaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/tipomaquina/{id}", model);
            await SetTipMaquina(result);
        }

        public async Task GetAllDataFromTipoMaquina(int skip, int take)
        {
            var result = await _http.GetFromJsonAsync<List<TipoMaquina>>($"api/tipomaquina/page/{skip}/{take}");
            if (result != null)
                TiposMaquinas = result;
        }
    }
}
