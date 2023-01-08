using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.Zona;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IZonaService
    {
        IEnumerable<Zona> Zonas { get; set; }

        Task GetAllZonas();
        Task GetZonaById(int id);
        Task CreateZona(CreateZonaDto model);
        Task DeleteZona(int id);
        Task UpdateZona(UpdateZonaDto model);
    }
}
