using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.LineaProduccion;

namespace Aplicacion.Services.Pages.Interfaces
{
    public interface ILineaProduccionServicePages
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
