using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using System.Net.Http.Json;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class TicketService : ITicketService
    {

        private readonly HttpClient _http;

        public TicketService(HttpClient http)
        {
            _http = http;
        }

        public List<Maquina> Maquinas { get; set; } = new();

        public List<Categoria> Categorias { get; set; } = new();

        public List<Usuario> Usuarios { get; set; } = new();

        public List<Urgencia> Urgencias { get; set; } = new();

        public List<Zona> Zona { get; set; } = new();

        public List<EstadoIntervencion> Estados { get; set; } = new();

        public List<Ticket> Tickets { get; set; } = new();

        public async Task CreateTicket(Ticket ticket)
        {
            var result = await _http.PostAsJsonAsync<Ticket>($"api/ticket", ticket);
            await SetTickets(result);
        }

        public async Task DeleteTicket(Ticket ticket)
        {
            var result = await _http.DeleteAsync($"api/ticket/{ticket.Id}");
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
    }
}
