using Dominio.Modelos.Configuracion;
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
        Task<List<Fabrica>> CreateFabrica(Fabrica fabrica);
        Task<List<Fabrica>> UpdateFabrica(int id, Fabrica fabrica);
        Task<List<Fabrica>> DeleteFabrica(Fabrica fabrica);
        Task<Fabrica> GetFabricaById(int id);
    }
}
