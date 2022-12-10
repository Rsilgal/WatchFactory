using Aplicacion.Repository;
using Dominio.Modelos.Intervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class IntervencionRepository : IIntervencionRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public IntervencionRepository(WatchFactoryDbContext watchFactory)
        {
            this._watchFactory = watchFactory;
        }

        public Intervencion CreateIntervencion(Intervencion intervencion)
        {
            throw new NotImplementedException();
        }

        public List<Intervencion> GetIntervenciones()
        {
            throw new NotImplementedException();
        }
    }
}
