using Dominio.Modelos.Configuracion;
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
        Task<List<LineaProduccion>> CreateLineaProduccion(LineaProduccion lineaProduccion);
        Task<List<LineaProduccion>> UpdateLineaProduccion(int id, LineaProduccion lineaProduccion);
        Task<List<LineaProduccion>> DeleteLineaProduccion(LineaProduccion lineaProduccion);
        Task<LineaProduccion> GetLineaProduccionById(int id);
        Task<List<LineaProduccion>> GetLineaProduccionByFabrica(int fabricaId);
    }
}
