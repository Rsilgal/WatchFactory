using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Urgencia;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IUrgenciaServicePages
    {
        IEnumerable<Urgencia> Urgencias { get; set; }

        Task GetAllUrgencias();
        Task<Urgencia> GetUrgenciaById(int id);
        Task CreateUrgencia(CreateUrgenciaDto model);
        Task DeleteUrgencia(int id);
        Task UpdateUrgencia(int id, UpdateUrgenciaDto model);
        Task GetAllDataFromUrgencia(int skip, int take);
    }
}
