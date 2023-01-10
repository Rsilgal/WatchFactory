using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Urgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IUrgenciaRepository
    {
        Task<List<Urgencia>> GetUrgencias();
        Task<List<Urgencia>> CreateUrgencia(CreateUrgenciaDto dto);
        Task<List<Urgencia>> UpdateUrgencia(int id, UpdateUrgenciaDto dto);
        Task<List<Urgencia>> DeleteUrgencia(int id);
        Task<Urgencia> GetUrgenciaById(int id);
    }
}
