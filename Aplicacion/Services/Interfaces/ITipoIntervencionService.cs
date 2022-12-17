using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface ITipoIntervencionService
    {
        List<TipoIntervencion> GetTipoIntervencion();
        
        TipoIntervencion CreateTipoIntervencion(
            {
                string Descripcion,
                int TicketID,
                int EstadoIntervencionID,
                int TipoIntervencionID
            }
        );
        
        Intervencion UpdateIntervencion(
            {
                string Descripcion,
                int TicketID,
                int EstadoIntervencionID,
                int TipoIntervencionID
            }
        );

        Intervencion DeleteIntervencion(
            {
                string Descripcion,
                int TicketID,
                int EstadoIntervencionID,
                int TipoIntervencionID
            }
        );

        Intervencion GetIntervencion(int id);
    }
}
