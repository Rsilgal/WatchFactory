using Dominio.Modelos.Configuracion;
using WatchFactory_Client.Models.Dtos.LineaProduccion;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface ILineaProduccionService
    {
        IEnumerable<LineaProduccion> Lineas { get; set; }
        IEnumerable<Fabrica> Fabricas { get; set; }
        Task GetAllLineas();
        Task<LineaProduccion> GetLineaById(int id);
        Task CreateLinea(CreateLineaDto model);
        Task DeleteLinea(int id);
        Task UpdateLinea(int id, UpdateLineaDto model);
        Task GetFabricas();
    }
}
