using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IMaquinaRepository
    {
        Task<List<Maquina>> GetAllMaquinas();
        Task<List<Maquina>> CreateMaquina(Maquina maquina);
        Task<List<Maquina>> UpdateMaquina(int id, Maquina maquina);
        Task<List<Maquina>> DeleteMaquina(Maquina maquina);
        Task<Maquina> GetMaquinaById(int id);
        Task<List<Maquina>> GetMaquinasByLinea(int lineaId);
        Task<List<Maquina>> GetMaquinasByTipoMaquina(int tipoMaquinaId);
        Task<List<Maquina>> GetMaquinasByFabrica(int fabricaId);
    }
}
