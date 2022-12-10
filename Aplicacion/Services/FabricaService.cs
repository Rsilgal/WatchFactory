using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
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

        public Fabrica CreateFabrica(Fabrica fabrica)
        {
            _fabricaRepository.CreateFabrica(fabrica);
            return fabrica;
        }

        public List<Fabrica> GetAllFabricas()
        {
            return _fabricaRepository.GetAllFabrica();
        }
    }
}
