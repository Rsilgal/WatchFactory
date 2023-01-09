using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Zona;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IZonaService
    {
        IEnumerable<Zona> Zonas { get; set; }

        Task GetAllZonas();
        Task<Zona> GetZonaById(int id);
        Task CreateZona(CreateZonaDto model);
        Task DeleteZona(int id);
        Task UpdateZona(int id, UpdateZonaDto model);
    }
}
