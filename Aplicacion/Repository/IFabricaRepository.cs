using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IFabricaRepository
    {
        Task<List<Fabrica>> GetAllFabrica();
        Task<List<Fabrica>> CreateFabrica(CreateFabricaDto fabrica);
        Task<List<Fabrica>> UpdateFabrica(int id, UpdateFabricaDto fabrica);
        Task<List<Fabrica>> DeleteFabrica(int id);
        Task<Fabrica> GetFabricaById(int id);
    }
}
