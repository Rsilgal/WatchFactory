using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using Dominio.Modelos.Dtos.EstadoIIntervencion;
using Aplicacion.Services.Pages.Interfaces;

namespace Aplicacion.Services.Pages
{
    public class EstadoIntervencionServicePages : IEstadoIntervencionPages
    {
        private readonly HttpClient _http;

        public EstadoIntervencionServicePages(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<EstadoIntervencion> Estados { get; set; }

        public async Task CreateEstado(CreateEstadoIntervencionDto model)
        {
            var result = await _http.PostAsJsonAsync("api/estadointervencion", model);
            await SetEstado(result);
        }

        private async Task SetEstado(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<EstadoIntervencion>>();
            Estados = response;
        }

        public async Task DeleteEstadoById(int id)
        {
            var result = await _http.DeleteAsync($"api/estadointervencion/{id}");
            await SetEstado(result);
        }

        public async Task GetAllEstados()
        {
            var result = await _http.GetFromJsonAsync<List<EstadoIntervencion>>("api/estadointervencion");
            if (result != null)
                Estados = result;
        }

        public async Task<EstadoIntervencion> GetEstadoById(int id)
        {
            var result = await _http.GetFromJsonAsync<EstadoIntervencion>($"api/estadointervencion/{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ningun estado de intervencion");
        }

        public async Task UpdateEstado(int id, UpdateEstadoIntervencionDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/estadointervencion/{id}", model);
            await SetEstado(result);
        }
    }
}
