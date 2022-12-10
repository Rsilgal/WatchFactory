using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface ITipoIntervencionRepository
    {
        List<TipoIntervencion> GetTipoIntervencion();
        TipoIntervencion CreateTipoIntervencion(TipoIntervencion tipo);
    }
}
