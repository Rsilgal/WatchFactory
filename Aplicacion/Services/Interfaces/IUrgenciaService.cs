using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IUrgenciaService
    {
        Task<List<Urgencia>> GetUrgencias();
        Task<List<Urgencia>> CreateUrgencia(Urgencia urgencia);
    }
}
