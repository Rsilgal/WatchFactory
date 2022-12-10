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
            _watchFactory.Intervenciones.Add(intervencion);
            _watchFactory.SaveChanges();

            return intervencion;
        }

        public Intervencion DeleteIntervencion(Intervencion intervencion)
        {
            _watchFactory.Intervenciones.Remove(intervencion);
            _watchFactory.SaveChanges();
            
            return intervencion;
        }

        public Intervencion GetIntervencion(int id)
        {
            return _watchFactory.Intervenciones.FirstOrDefault(e => e.Id == id);
        }

        public List<Intervencion> GetIntervenciones()
        {
            return _watchFactory.Intervenciones.ToList();
        }

        public Intervencion UpdateIntervencion(Intervencion newIntervencion)
        {
            _watchFactory.Intervenciones.Update(newIntervencion);
            _watchFactory.SaveChanges();

            return newIntervencion;
        }
    }
}
