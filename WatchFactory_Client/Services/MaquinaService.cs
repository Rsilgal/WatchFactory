using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using Dominio.Modelos.Dtos.Maquina;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class MaquinaService : IMaquinaService
    {
        private readonly HttpClient _http;

        public MaquinaService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<Maquina> Maquinas { get; set; }
        public IEnumerable<TipoMaquina> Tipos { get; set; }
        public IEnumerable<LineaProduccion> Lineas { get; set; }
        public IEnumerable<Fabrica> Fabricas { get; set; }

        public async Task CreateMaquina(CreateMaquinaDto model)
        {
            var result = await _http.PostAsJsonAsync("api/maquina", model);
            await SetMaquina(result);
        }

        public async Task SetMaquina(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Maquina>>();
            Maquinas = response;
        }

        public async Task DeleteMaquina(int id)
        {
            var result = await _http.DeleteAsync($"api/maquina/{id}");
            await SetMaquina(result);
        }

        public async Task GetAllFabricas()
        {
            var result = await _http.GetFromJsonAsync<List<Fabrica>>("api/fabrica");
            if (result != null)
                Fabricas = result;
        }

        public async Task GetAllLineas()
        {
            var result = await _http.GetFromJsonAsync<List<LineaProduccion>>("api/linea");
            if (result != null)
                Lineas = result;
        }

        public async Task GetAllMaquinas()
        {
            var result = await _http.GetFromJsonAsync<List<Maquina>>("api/maquina");
            if (result != null)
                Maquinas = result;
        }

        public async Task GetAllTipoMaquina()
        {
            var result = await _http.GetFromJsonAsync<List<TipoMaquina>>("api/tipomaquina");
            if (result != null)
                Tipos = result;
        }

        public async Task<Maquina> GetMaquinaById(int id)
        {
            var result = await _http.GetFromJsonAsync<Maquina>($"api/maquina/{id}");
            return result;
        }

        public async Task UpdateMaquina(int id, UpdateMaquinaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/maquina/{id}", model);
            await SetMaquina(result);
        }

        public async Task GetAllDataFromMaquina(int skip, int take)
        {
            var result = await _http.GetFromJsonAsync<List<Maquina>>($"api/maquina/page/{skip}/{take}");
            if (result != null)
                Maquinas= result;
        }
    }
}
