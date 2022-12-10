using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class LineaProduccionRepository : ILineaProduccionRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;
        public LineaProduccionRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory= watchFactory;
        }
        public LineaProduccion CreateLineaProduccion(LineaProduccion lineaProduccion)
        {
            throw new NotImplementedException();
        }

        public List<LineaProduccion> GetAllLineasProduccion()
        {
            throw new NotImplementedException();
        }
    }
}
