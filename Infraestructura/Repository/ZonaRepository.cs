using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class ZonaRepository : IZonaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public ZonaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public Zona CreateZona(Zona zona)
        {
            throw new NotImplementedException();
        }

        public List<Zona> GetZonas()
        {
            throw new NotImplementedException();
        }
    }
}
