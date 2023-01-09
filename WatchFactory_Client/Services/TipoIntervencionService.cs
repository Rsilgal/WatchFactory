﻿using Dominio.Modelos.Configuracion;
using System.Net.Http.Json;
using WatchFactory_Client.Models.Dtos.TipoIntervencion;
using WatchFactory_Client.Services.Interfaces;

namespace WatchFactory_Client.Services
{
    public class TipoIntervencionService : ITipoIntervencion
    {
        private readonly HttpClient _http;

        public TipoIntervencionService(HttpClient http)
        {
            _http = http;
        }

        public IEnumerable<TipoIntervencion> Tipos { get; set; }

        public async Task CreateTipoIntervencion(CreateTipoIntervencionDto model)
        {
            var result = await _http.PostAsJsonAsync("api/tipointervencion", model);
            await SetTipo(result);
        }

        private async Task SetTipo(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<TipoIntervencion>>();
            Tipos = response;
        }

        public async Task DeleteTipoIntervencion(int id)
        {
            var result = await _http.DeleteAsync($"api/tipointervencion/{id}");
            await SetTipo(result);
        }

        public async Task GetAllTiposIntervencion()
        {
            var result = await _http.GetFromJsonAsync<List<TipoIntervencion>>("api/tipointervencion");
            if (result != null)
                Tipos= result;
        }

        public async Task<TipoIntervencion> GetTipoIntervencionById(int id)
        {
            var result = await _http.GetFromJsonAsync<TipoIntervencion>($"api/tipointervencion/{id}");
            if (result != null)
                return result;
            throw new Exception("No se ha encontrado ningún tipo de intervencion");
        }

        public async Task UpdateTipoIntervencion(int id, UpdateTipoIntervencionDto model)
        {
            var result = await _http.PutAsJsonAsync($"api/tipointervencion/{id}", model);
            await SetTipo(result);
        }
    }
}
