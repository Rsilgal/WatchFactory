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

        Intervencion UpdateIntervencion(Intervencion newIntervencion);

        Intervencion DeleteIntervencion(Intervencion intervencion);

        Intervencion GetIntervencion(int id);
        List<Intervencion> GetIntervencionesByFabrica(int FabricaID);
        List<Intervencion> GetIntervencionesByLinea(int LineaID);
        List<Intervencion> GetIntervencionesByTipoIntervencion(int TipoIntervencionID);
        List<Intervencion> GetIntervencionesByMaquina(int MaquinaID);

    }
}
