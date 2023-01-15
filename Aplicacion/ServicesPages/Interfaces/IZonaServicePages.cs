using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Zona;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface IZonaServicePages
    {
        IEnumerable<Zona> Zonas { get; set; }

        Task GetAllZonas();
        Task<Zona> GetZonaById(int id);
        Task CreateZona(CreateZonaDto model);
        Task DeleteZona(int id);
        Task UpdateZona(int id, UpdateZonaDto model);
        Task GetAllDataFromZona(int skip, int take);
    }
}
