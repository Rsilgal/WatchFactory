using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IFabricaService
    {
        Task<List<Fabrica>> GetAllFabricas();
        Task<List<Fabrica>> CreateFabrica(CreateFabricaDto model);
        Task<Fabrica> GetFabricaById(int id);
        Task<List<Fabrica>> UpdateFabrica(int id, UpdateFabricaDto model);
        Task<List<Fabrica>> DeleteFabrica(int id);
    }
}
