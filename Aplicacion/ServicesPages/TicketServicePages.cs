using Aplicacion.Services.Pages.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Ticket;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using System.Net.Http.Json;


namespace Aplicacion.Services.Pages
{
    public class TicketServicePages : ITicketServicePages
    {

        private readonly HttpClient _http;

        public TicketServicePages(HttpClient http)
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

        public List<Ticket> Tickets { get; set; } = new();

        public async Task CreateTicket(CreateTicketDto ticket)
        {
            var result = await _http.PostAsJsonAsync($"api/tickets", ticket);
            await SetTickets(result);
        }

        public async Task DeleteTicket(int id)
        {
            var result = await _http.DeleteAsync($"api/tickets/{id}");
            await SetTickets(result);
        }

        private async Task SetTickets(HttpResponseMessage result)
        {

            var response = await result.Content.ReadFromJsonAsync<List<Ticket>>();
            Tickets = response;
        }

        public async Task GetAllTicket()
        {
            var result = await _http.GetFromJsonAsync<List<Ticket>>("api/tickets");
            if (result != null)
                Tickets = result;
        }

        public async Task<Ticket> GetTicket(int id)
        {
            var result = await _http.GetFromJsonAsync<Ticket>($"api/tickets/{id}");
            if (result != null)
                return result;
            throw new Exception("Ticket no encontrado!");
        }

        public async Task UpdateTicket(int id, UpdateTicketDto ticket)
        {
            var result = await _http.PutAsJsonAsync($"api/tickets/{id}", ticket);
            await SetTickets(result);
        }

        public async Task GetFabricas()
        {
            var result = await _http.GetFromJsonAsync<List<Fabrica>>("api/fabrica");
            if (result != null)
                Fabricas = result;
        }

        public async Task GetLinea()
        {
            var result = await _http.GetFromJsonAsync<List<LineaProduccion>>("api/linea");
            if (result != null)
                Lineas = result;
        }

        public async Task GetMaquina()
        {
            var result = await _http.GetFromJsonAsync<List<Maquina>>("api/maquina");
            if (result != null)
                Maquinas = result;
        }

        public async Task GetCategorias()
        {
            var result = await _http.GetFromJsonAsync<List<Categoria>>("api/categoria");
            if (result != null)
                Categorias = result;
        }

        public async Task GetUrgencia()
        {
            var result = await _http.GetFromJsonAsync<List<Urgencia>>("api/urgencia");
            if (result != null)
                Urgencias= result;
        }

        public async Task GetZona()
        {
            var result = await _http.GetFromJsonAsync<List<Zona>>("api/zona");
            if (result != null)
                Zonas = result;
        }

        public async Task GetEstadoIntervencion()
        {
            var result = await _http.GetFromJsonAsync<List<EstadoIntervencion>>("api/zona");
            if(result != null)
                Estados= result;
        }

        public async Task GetAllDataFromTickets(int skip, int take)
        {
            var result = await _http.GetFromJsonAsync<List<Ticket>>($"api/tickets/page/{skip}/{take}");
            if (result != null)
                Tickets = result;
        }
    }
}
