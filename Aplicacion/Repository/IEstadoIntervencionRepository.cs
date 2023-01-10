using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.EstadoIIntervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IEstadoIntervencionRepository
    {
        Task<List<EstadoIntervencion>> GetEstadoIntervencion();
        Task<List<EstadoIntervencion>> CreateEstadoIntervencion(CreateEstadoIntervencionDto model);
        Task<List<EstadoIntervencion>> UpdateEstadoIntervencion(int id, UpdateEstadoIntervencionDto model);
        Task<List<EstadoIntervencion>> DeleteEstadoIntervencion(int id);
        Task<EstadoIntervencion> GetEstadoIntervencionById(int id);
    }
}
