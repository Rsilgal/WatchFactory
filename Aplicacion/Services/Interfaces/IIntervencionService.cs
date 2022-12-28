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
        Intervencion CreateIntervencion(string Descripcion, int TicketID, int EstadoIntervencionID, int TipoIntervencionID);

        Intervencion UpdateIntervencion(int id, string Descripcion, int TicketID, int EstadoIntervencionID, int TipoIntervencionID);

        Intervencion DeleteIntervencion(int id);

        Intervencion GetIntervencion(int id);
        List<Intervencion> GetIntervencionesByFabrica(int FabricaID);
        List<Intervencion> GetIntervencionesByLinea(int LineaID);
        List<Intervencion> GetIntervencionesByTipoIntervencion(int TipoIntervencionID);
        List<Intervencion> GetIntervencionesByMaquina(int MaquinaID);
    }
}
