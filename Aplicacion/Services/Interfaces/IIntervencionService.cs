using Dominio.Modelos.Dtos.Intervencion;
using Dominio.Modelos.Intervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IIntervencionService
    {
        Task<List<Intervencion>> GetIntervenciones();
        Task<List<Intervencion>> CreateIntervencion(CreateIntervencionDto intervencion);

        Task<List<Intervencion>> UpdateIntervencion(int id, UpdateIntervencionDto intervencion);

        Task<List<Intervencion>> DeleteIntervencion(int id);

        Task<Intervencion> GetIntervencionById(int id);
        Task<List<Intervencion>> GetIntervencionesByTipoIntervencion(int TipoIntervencionID);
        Task<List<Intervencion>> GetAllDataFromIntervenciones(int skip, int take);
    }
}
