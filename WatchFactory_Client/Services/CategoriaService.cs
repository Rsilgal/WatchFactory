using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using WatchFactory_Client.Models.Dtos.Categoria;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _http;

        public CategoriaService(HttpClient http) 
        {
            _http = http;
        }
        public IEnumerable<Categoria> Categorias { get; set; }

        public async Task CreateCategoria(CreateCategoriaDto model)
        {
            var result = await _http.PostAsJsonAsync($"api/categoria", model);
            await SetCategoria(result);
        }

        public async Task DeleteCategoria(int id)
        {
            var result = await _http.DeleteAsync($"api/categoria/{id}");
            await SetCategoria(result);
        }

        public async Task GetAllCategorias()
        {
            var result = await _http.GetFromJsonAsync<List<Categoria>>("api/categoria");
            if (result != null)
                Categorias = result;
        }

        public async Task<Categoria> GetCategoriaByID(int id)
        {
            var result = await _http.GetFromJsonAsync<Categoria>($"api/categoria/{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ninguna intervención");
        }

        public async Task UpdateCategoria(int id, UpdateCategoriaDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/categoria/{id}",model); 
            await SetCategoria(result);
        }

        public async Task SetCategoria(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Categoria>>();
            Categorias = response;
        }
    }
}
