using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoIntervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface ITipoIntervencionRepository
    {
        Task<List<TipoIntervencion>> GetTipoIntervencion();
        Task<List<TipoIntervencion>> CreateTipoIntervencion(CreateTipoIntervencionDto model);
        Task<List<TipoIntervencion>> UpdateTipoIntervencion(int id, UpdateTipoIntervencionDto model);
        Task<List<TipoIntervencion>> DeleteTipoIntervencion(int id);
        Task<TipoIntervencion> GetTipoIntervencionById(int id);
        Task<List<TipoIntervencion>> GetAllDataFromTipoIntervencion(int skip, int take);
    }
}
