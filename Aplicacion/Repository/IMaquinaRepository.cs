using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Maquina;
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
        Task<List<Maquina>> CreateMaquina(CreateMaquinaDto maquina);
        Task<List<Maquina>> UpdateMaquina(int id, UpdateMaquinaDto maquina);
        Task<List<Maquina>> DeleteMaquina(int id);
        Task<Maquina> GetMaquinaById(int id);
        Task<List<Maquina>> GetMaquinasByLinea(int lineaId);
        Task<List<Maquina>> GetMaquinasByTipoMaquina(int tipoMaquinaId);
        Task<List<Maquina>> GetMaquinasByFabrica(int fabricaId);
        Task<List<Maquina>> GetAllDataFromMaquina(int skip, int take);
    }
}
