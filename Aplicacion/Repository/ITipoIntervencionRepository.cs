using Dominio.Modelos.Configuracion;
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
        Task<List<TipoIntervencion>> CreateTipoIntervencion(TipoIntervencion tipo);
        Task<List<TipoIntervencion>> UpdateTipoIntervencion(int id,TipoIntervencion tipo);
        Task<List<TipoIntervencion>> DeleteTipoIntervencion(TipoIntervencion tipo);
        Task<TipoIntervencion> GetTipoIntervencionById(int id);
    }
}
