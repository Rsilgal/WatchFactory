using Aplicacion.Repository;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
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

        public List<Intervencion> GetIntervencionesByFabrica(int FabricaID)
        {
            var lineas = _watchFactory.Lineas.Where(e => e.FabricaID == FabricaID).ToList();
            if (lineas == null) throw new Exception();

            var maquinas = _watchFactory.Maquinas.Where(e => lineas.All(l => l.Id == e.LineaProduccionID)).ToList();
            if (maquinas == null) throw new Exception();

            var tickets = _watchFactory.Tickets.Where(e => maquinas.All(m => m.Id == e.MaquinaID)).ToList();
            if (tickets == null) throw new Exception();

            List<Intervencion> intervenciones = _watchFactory.Intervenciones.Where(e => tickets.All(t => t.Id == e.TicketID)).ToList();

            return intervenciones;
        }

        public List<Intervencion> GetIntervencionesByLinea(int LineaID)
        {
            var maquinas = _watchFactory.Maquinas.Where(e => e.LineaProduccionID== LineaID).ToList();
            if (maquinas==null) throw new Exception();

            var tickets = _watchFactory.Tickets.Where(e => maquinas.All(m => m.Id == e.MaquinaID)).ToList();
            if (tickets == null) throw new Exception();

            List<Intervencion> intervenciones = _watchFactory.Intervenciones.Where(e => tickets.All(t => t.Id == e.TicketID)).ToList();

            return intervenciones;
        }

        public List<Intervencion> GetIntervencionesByMaquina(int MaquinaID)
        {
            var maquinas = _watchFactory.Maquinas.Where(e => e.Id == MaquinaID).ToList();
            if (maquinas == null) throw new Exception();

            var tickets = _watchFactory.Tickets.Where(e => maquinas.All(m => m.Id == e.MaquinaID)).ToList();
            if (tickets == null) throw new Exception();

            List<Intervencion> intervenciones = _watchFactory.Intervenciones.Where(e => tickets.All(t => t.Id == e.TicketID)).ToList();

            return intervenciones;
        }

        public List<Intervencion> GetIntervencionesByTipoIntervencion(int TipoIntervencionID)
        {
            List<Intervencion> intervenciones = _watchFactory.Intervenciones.Where(e => e.TipoIntervencionID == TipoIntervencionID).ToList();

            return intervenciones;
        }

        public Intervencion UpdateIntervencion(Intervencion newIntervencion)
        {
            _watchFactory.Intervenciones.Update(newIntervencion);
            _watchFactory.SaveChanges();

            return newIntervencion;
        }
    }
}
