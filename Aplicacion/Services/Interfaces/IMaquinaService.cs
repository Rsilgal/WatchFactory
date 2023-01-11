using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Maquina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IMaquinaService
    {
        Task<List<Maquina>> GetAllMaquinas();
        Task<List<Maquina>> CreateMaquina(CreateMaquinaDto maquina);
        Task<Maquina> GetMaquinaById(int id);
        Task<List<Maquina>> UpdateMaquina(int id, UpdateMaquinaDto model);
        Task<List<Maquina>> DeleteMaquina(int id);
        Task<List<Maquina>> GettAllDataFromMaquina(int skip, int take);
    }
}
