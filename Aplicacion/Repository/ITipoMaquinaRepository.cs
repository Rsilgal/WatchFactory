using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoMaquina;
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
        Task<List<TipoMaquina>> CreateTipoMaquina(CreateTipoMaquinaDto model);
        Task<List<TipoMaquina>> UpdateTipoMaquina(int id, UpdateTipoMaquinaDto model);
        Task<List<TipoMaquina>> DeleteTipoMaquina(int id);
        Task<TipoMaquina> GetTipoMaquinaById(int id);
        Task<List<TipoMaquina>> GetAllDataFromTipoMaquinas(int skip, int take);
    }
}
