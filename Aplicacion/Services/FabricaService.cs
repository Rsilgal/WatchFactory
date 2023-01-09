using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
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

        public async Task<List<Fabrica>> CreateFabrica(Fabrica fabrica)
        {
            return await _fabricaRepository.CreateFabrica(fabrica);
        }

        public async Task<List<Fabrica>> GetAllFabricas()
        {
            return await _fabricaRepository.GetAllFabrica();
        }
    }
}
