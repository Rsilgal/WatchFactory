using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using Dominio.Modelos.Dtos.LineaProduccion;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class LineaProduccionService : ILineaProduccionService
    {
        private readonly HttpClient _http;

        public LineaProduccionService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<LineaProduccion> Lineas { get; set; }
        public IEnumerable<Fabrica> Fabricas { get; set; }

        public async Task CreateLinea(CreateLineaDto model)
        {
            var result = await _http.PostAsJsonAsync("api/linea", model);
            await SetLineaProduccion(result);
        }

        private async Task SetLineaProduccion(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<LineaProduccion>>();
            Lineas = response;
        }

        public async Task DeleteLinea(int id)
        {
            var result = await _http.DeleteAsync("api/linea");
            await SetLineaProduccion(result);
        }

        public async Task GetAllLineas()
        {
            var result = await _http.GetFromJsonAsync<List<LineaProduccion>>("api/linea");
            if (result != null)
                Lineas = result;
        }

        public async Task GetFabricas()
        {
            var result = await _http.GetFromJsonAsync<List<Fabrica>>($"api/fabrica");
            if (result != null)
                Fabricas = result;
        }

        public async Task<LineaProduccion> GetLineaById(int id)
        {
            var result = await _http.GetFromJsonAsync<LineaProduccion>($"api/linea/{id}");
            if (result != null)
                return result;

            throw new Exception("No se ha encontrado ninguna linea");

        }

        public async Task UpdateLinea(int id, UpdateLineaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/linea/{id}", model);
            await SetLineaProduccion(result);
        }
    }
}
