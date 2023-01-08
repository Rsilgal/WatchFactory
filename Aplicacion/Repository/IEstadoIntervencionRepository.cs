using Dominio.Modelos.Configuracion;
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
        Task<List<EstadoIntervencion>> CreateEstadoIntervencion(EstadoIntervencion estado);
        Task<List<EstadoIntervencion>> UpdateEstadoIntervencion(int id, EstadoIntervencion estado);
        Task<List<EstadoIntervencion>> DeleteEstadoIntervencion(EstadoIntervencion estado);
        Task<EstadoIntervencion> GetEstadoIntervencionById(int id);
    }
}
