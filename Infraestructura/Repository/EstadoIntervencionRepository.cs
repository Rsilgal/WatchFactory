using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class EstadoIntervencionRepository : IEstadoIntervencionRepository
    {
        public readonly WatchFactoryDbContext _watchFactory;
        public EstadoIntervencionRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory= watchFactory;
        }

        public EstadoIntervencion CreateEstadoIntervencion(EstadoIntervencion estado)
        {
            throw new NotImplementedException();
        }

        public List<EstadoIntervencion> GetEstadoIntervencion()
        {
            throw new NotImplementedException();
        }
    }
}
