using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Usuarios;
using System.Net.Http.Json;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class TicketService : ITicketService
    {

        private readonly HttpClient _http;
        private readonly IConfiguracionService _configurationService;

        public TicketService(HttpClient http, IConfiguracionService configuracionService)
        {
            _http = http;
            _configurationService = configuracionService;
        }

        public List<Fabrica> Fabricas { get; set; } = new();
        public List<LineaProduccion> Lineas { get; set; } = new();

        public List<Maquina> Maquinas { get; set; } = new();

        public List<Categoria> Categorias { get; set; } = new();

        public List<Usuario> Usuarios { get; set; } = new();

        public List<Urgencia> Urgencias { get; set; } = new();

        public List<Zona> Zonas { get; set; } = new();

        public List<EstadoIntervencion> Estados { get; set; } = new();

        public List<Ticket> Tickets { get; set; } = new();

        public async Task CreateTicket(Ticket ticket)
        {
            var result = await _http.PostAsJsonAsync<Ticket>($"api/ticket", ticket);
            await SetTickets(result);
        }

        public async Task DeleteTicket(int id)
        {
            var result = await _http.DeleteAsync($"api/ticket/{id}");
            await SetTickets(result);
        }

        private async Task SetTickets(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Ticket>>();
            Tickets = response;
        }

        public async Task GetAllTicket()
        {
            var result = await _http.GetFromJsonAsync<List<Ticket>>("api/ticket");
            if (result != null)
                Tickets = result;
        }

        public async Task<Ticket> GetTicket(int id)
        {
            var result = await _http.GetFromJsonAsync<Ticket>($"api/ticket/{id}");
            if (result != null)
                return result;
            throw new Exception("Ticket no encontrado!");
        }

        public async Task UpdateTicket(Ticket ticket)
        {
            var result = await _http.PutAsJsonAsync<Ticket>($"api/ticket/{ticket.Id}", ticket);
            await SetTickets(result);
        }

        public async Task GetFabricas()
        {
            await _configurationService.GetFabricas();
            Fabricas = _configurationService.Fabricas;
        }

        // TODO: Revisar
        public async Task GetLineas()
        {
            await _configurationService.GetLineas();
            Lineas = _configurationService.Lineas;
        }

        // TODO: Revisar
        public async Task GetMaquinas()
        {
            await _configurationService.GetMaquinas();
            Maquinas = _configurationService.Maquinas;
        }

        public async Task GetCategorias()
        {
            await _configurationService.GetCategorias();
            Categorias = _configurationService.Categorias;
        }

        public async Task GetUsuarios()
        {
            await _configurationService.GetUsuarios();
            Usuarios = _configurationService.Usuarios;
        }

        public async Task GetUrgencias()
        {
            await _configurationService.GetUrgencias();
            Urgencias = _configurationService.Urgencias;
        }

        public async Task GetZonas()
        {
            await _configurationService.GetZonas();
            Zonas = _configurationService.Zonas;
        }

        public async Task GetEstados()
        {
            await _configurationService.GetEstados();
            Estados = _configurationService.Estados;
        }
    }
}
