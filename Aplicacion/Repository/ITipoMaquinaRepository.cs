using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface ITipoMaquinaRepository
    {
        Task<List<TipoMaquina>> GetAllTipoMaquinas();
        Task<List<TipoMaquina>> CreateTipoMaquina(TipoMaquina tipoMaquina);
        Task<List<TipoMaquina>> UpdateTipoMaquina(int id, TipoMaquina tipoMaquina);
        Task<List<TipoMaquina>> DeleteTipoMaquina(TipoMaquina tipoMaquina);
        Task<TipoMaquina> GetTipoMaquinaById(int id);
    }
}
