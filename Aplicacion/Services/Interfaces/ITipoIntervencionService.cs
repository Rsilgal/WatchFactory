using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoIntervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface ITipoIntervencionService
    {
        Task<List<TipoIntervencion>> GetTipoIntervencion();

        Task<List<TipoIntervencion>> CreateTipoIntervencion(CreateTipoIntervencionDto model);
        Task<List<TipoIntervencion>> UpdateTipoIntervecion(int id, UpdateTipoIntervencionDto model);
        Task<TipoIntervencion> GetTipoIntervecionById(int id);
        Task<List<TipoIntervencion>> DeleteTipoIntervencion(int id);
        Task<List<TipoIntervencion>> GetAllDataFromTipoIntervencion(int skip, int take);
    }
}
