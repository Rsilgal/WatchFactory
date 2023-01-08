using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.Categoria;
using WatchFactory_Client.Models.Dtos.Urgencia;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IUrgenciaService
    {
        IEnumerable<Urgencia> Urgencias { get; set; }

        Task GetAllUrgencias();
        Task GetUrgenciaById(int id);
        Task CreateUrgencia(CreateUrgenciaDto model);
        Task DeleteUrgencia(int id);
        Task UpdateUrgencia(UpdateUrgenciaDto model);
    }
}
