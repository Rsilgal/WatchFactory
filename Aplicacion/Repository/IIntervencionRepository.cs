using Dominio.Modelos.Intervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IIntervencionRepository
    {
        List<Intervencion> GetIntervenciones();
        Intervencion CreateIntervencion(Intervencion intervencion);
    }
}
