using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.LineaProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface ILinneaProduccionService
    {
        Task<List<LineaProduccion>> GetAllLineasProduccion();
        Task<List<LineaProduccion>> CreateLineaProduccion(CreateLineaDto lineaProduccion);
        Task<LineaProduccion> GetLineaById(int id);
        Task<List<LineaProduccion>> UpdateLinea(int id, UpdateLineaDto model);
        Task<List<LineaProduccion>> DeleteLinea(int id);
    }
}
