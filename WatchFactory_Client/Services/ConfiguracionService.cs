using System.Net.Http.Json;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Usuarios;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class ConfiguracionService : IConfiguracionService
    {
        private readonly HttpClient _http;

        public ConfiguracionService(HttpClient http)
        {
            _http = http;
        }

        public List<Fabrica> Fabricas { get; set; } = new();
        public List<LineaProduccion> Lineas { get; set; } = new();
        public List<Maquina> Maquinas { get; set; } = new();
        public List<Categoria> Categorias { get; set; } = new();
        public List<Usuario> Usuarios { get; set; } = new();
        public List<Urgencia> Urgencias { get; set; } = new();
        public List<Zona> Zonas { get; set; } = new();
        public List<EstadoIntervencion> Estados { get; set; } = new();

        public async Task GetCategorias()
        {
            var result = await _http.GetFromJsonAsync<List<Categoria>>("api/categoria");
            if (result != null)
                Categorias = result;
        }

        public async Task GetEstados()
        {
            var result = await _http.GetFromJsonAsync<List<EstadoIntervencion>>("api/estadointervencion");
            if (result != null)
                Estados = result;
        }

        public async Task GetFabricas()
        {
            var result = await _http.GetFromJsonAsync<List<Fabrica>>("api/fabrica");
            if (result != null)
                Fabricas = result;
        }

        public async Task GetLineas()
        {
            var result = await _http.GetFromJsonAsync<List<LineaProduccion>>("api/lineaproduccion");
            if (result != null)
                Lineas = result;
        }

        public async Task GetMaquinas()
        {
            var result = await _http.GetFromJsonAsync<List<Maquina>>("api/maquina");
            if (result != null)
                Maquinas = result;
        }

        public async Task GetUrgencias()
        {
            var result = await _http.GetFromJsonAsync<List<Urgencia>>("api/urgencia");
            if (result != null)
                Urgencias = result;
        }

        public async Task GetUsuarios()
        {
            var result = await _http.GetFromJsonAsync<List<Usuario>>("api/usuario");
            if (result != null)
                Usuarios = result;
        }

        public async Task GetZonas()
        {
            var result = await _http.GetFromJsonAsync<List<Zona>>("api/zona");
            if (result != null)
                Zonas = result;
        }
    }
}