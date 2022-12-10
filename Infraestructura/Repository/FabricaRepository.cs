using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class FabricaRepository : IFabricaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public FabricaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public Fabrica CreateFabrica(Fabrica fabrica)
        {
            throw new NotImplementedException();
        }

        public List<Fabrica> GetAllFabrica()
        {
            throw new NotImplementedException();
        }
    }
}
