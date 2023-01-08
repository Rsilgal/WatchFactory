using Dominio.Modelos.Configuracion;
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
        Task<List<Urgencia>> CreateUrgencia(Urgencia urgencia);
        Task<List<Urgencia>> UpdateUrgencia(int id, Urgencia urgencia);
        Task<List<Urgencia>> DeleteUrgencia(Urgencia urgencia);
        Task<Urgencia> GetUrgenciaById(int id);
    }
}
