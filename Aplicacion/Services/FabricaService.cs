using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Fabrica;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class FabricaService : IFabricaService
    {
        private readonly IFabricaRepository _fabricaRepository;

        public FabricaService(IFabricaRepository fabricaRepository)
        {
            _fabricaRepository = fabricaRepository;
        }

        public async Task<List<Fabrica>> CreateFabrica(CreateFabricaDto model)
        {
            return await _fabricaRepository.CreateFabrica(model);
        }

        public async Task<List<Fabrica>> DeleteFabrica(int id)
        {
            return await _fabricaRepository.DeleteFabrica(id);
        }

        public async Task<List<Fabrica>> GetAllFabricas()
        {
            return await _fabricaRepository.GetAllFabrica();
        }

        public async Task<Fabrica> GetFabricaById(int id)
        {
            return await _fabricaRepository.GetFabricaById(id);
        }

        public async Task<List<Fabrica>> UpdateFabrica(int id, UpdateFabricaDto model)
        {
            return await _fabricaRepository.UpdateFabrica(id, model);
        }
    }
}
