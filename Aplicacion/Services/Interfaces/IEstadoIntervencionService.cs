using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.EstadoIIntervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IEstadoIntervencionService
    {
        Task<List<EstadoIntervencion>> GetEstadoIntervencion();
        Task<List<EstadoIntervencion>> DeleteEstadoIntervencion(int id);
        Task<EstadoIntervencion> GetEstadoIntervencionById(int id);
        Task<List<EstadoIntervencion>> UpdateEstadoIntervencion(int id, UpdateEstadoIntervencionDto model);
        Task<List<EstadoIntervencion>> CreateEstadoIntervencion(CreateEstadoIntervencionDto model);
    }
}
