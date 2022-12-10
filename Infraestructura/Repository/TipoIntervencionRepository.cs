using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class TipoIntervencionRepository : ITipoIntervencionRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public TipoIntervencionRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public TipoIntervencion CreateTipoIntervencion(TipoIntervencion tipo)
        {
            throw new NotImplementedException();
        }

        public List<TipoIntervencion> GetTipoIntervencion()
        {
            throw new NotImplementedException();
        }
    }
}
