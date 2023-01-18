using Aplicacion.Services.Pages.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Intervencion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using System.Net.Http.Json;

namespace Aplicacion.Services.Pages
{
    public class IntervencionServicePages : IIntervencionServicePages
    {
        private readonly HttpClient _http;

        public IntervencionServicePages(HttpClient http)
        {
            _http = http;
        }

        public List<Intervencion> Intervenciones { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<EstadoIntervencion> Estados { get; set; }
        public List<TipoIntervencion> Tipos { get; set; }

        public async Task CreateIntervencion(CreateIntervencionDto intervencion)
        {
            var result = await _http.PostAsJsonAsync($"api/intervencion", intervencion);
            await SetIntervencion(result);
        }

        public async Task DeleteIntervencion(int id)
        {
            var result = await _http.DeleteAsync($"api/intervencion/{id}");
            await SetIntervencion(result);
        }

        public async Task GetAllDataFromIntervencion(int id, int skip, int take)
        {
            var result = await _http.GetFromJsonAsync<List<Intervencion>>($"api/intervencion/{id}/{skip}/{take}");
            if (result != null)
                Intervenciones = result;
        }

        public async Task GetEstadoIntervencion()
        {
            var result = await _http.GetFromJsonAsync<List<EstadoIntervencion>>("api/estadointervencion");
            if (result != null)
                Estados = result;
        }

        public async Task<Intervencion> GetIntervencion(int id)
        {
            var result = await _http.GetFromJsonAsync<Intervencion>($"api/intervencion/{id}");
            if (result != null)
                return result;
            throw new Exception("No se encontro ninguna intervencion.");
        }

        public async Task GetIntervenciones()
        {
            var result = await _http.GetFromJsonAsync<List<Intervencion>>("api/intervencion");
            if (result != null)
                Intervenciones = result;
        }

        public async Task GetTipoIntervencion()
        {
            var result = await _http.GetFromJsonAsync<List<TipoIntervencion>>("api/tipointervencion");
            if (result != null)
                Tipos = result;
        }

        public async Task UpdateIntervencion(int id, UpdateIntervencionDto intervencion)
        {
            var result = await _http.PutAsJsonAsync($"api/intervencion/{id}", intervencion);
            await SetIntervencion(result);
        }

        private async Task SetIntervencion(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Intervencion>>();
            Intervenciones = response;
        }
    }
}
