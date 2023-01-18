using Aplicacion.ServicesPages.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ServicesPages
{
    public class EmpresaServicePages : IEmpresaServicePages
    {
        private readonly HttpClient _http;

        public EmpresaServicePages(HttpClient http)
        {
            _http = http;
        }
        public List<EstadoIntervencion> Estados { get; set; }
        public Empresa Empresa { get; set; }

        public async Task GetEstadosIntervenciones()
        {
            var result = await _http.GetFromJsonAsync<List<EstadoIntervencion>>("api/estadointervencion");
            if (result != null)
            {
                Estados = result;
            }
        }

        public async Task GetEmpresa()
        {
            var result = await _http.GetFromJsonAsync<Empresa>("api/empresa");
            if (result != null)
            {
                Empresa = result;
            }
        }

        public async Task UpdateCompanyData(Empresa empresa)
        {
            var result = await _http.PutAsJsonAsync("api/empresa", empresa);
            var response = await result.Content.ReadFromJsonAsync<Empresa>();
            Empresa = response;
        }

        public async Task<string> GetNombre()
        {
            var result = await _http.GetAsync("api/empresa/name");
            var response = await result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
