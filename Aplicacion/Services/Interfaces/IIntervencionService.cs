using Dominio.Modelos.Intervencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IIntervencionService
    {
        List<Intervencion> GetIntervenciones();
        Intervencion CreateIntervencion(Intervencion intervencion);

        Intervencion UpdateIntervencion(Intervencion newIntervencion);

        Intervencion DeleteIntervencion(Intervencion intervencion);

        Intervencion GetIntervencion(int id);
    }
}
