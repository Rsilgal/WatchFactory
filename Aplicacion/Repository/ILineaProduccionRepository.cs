using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.LineaProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface ILineaProduccionRepository
    {
        Task<List<LineaProduccion>> GetAllLineasProduccion();
        Task<List<LineaProduccion>> CreateLineaProduccion(CreateLineaDto lineaProduccion);
        Task<List<LineaProduccion>> UpdateLineaProduccion(int id, UpdateLineaDto lineaProduccion);
        Task<List<LineaProduccion>> DeleteLineaProduccion(int id);
        Task<LineaProduccion> GetLineaProduccionById(int id);
        Task<List<LineaProduccion>> GetLineaProduccionByFabrica(int fabricaId);
    }
}
