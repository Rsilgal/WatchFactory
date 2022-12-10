using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class TipoIntervencionService : ITipoIntervencionService
    {
        private readonly ITipoIntervencionRepository _tipoIntervencionRepository;

        public TipoIntervencionService(ITipoIntervencionRepository tipoIntervencionRepository)
        {
            _tipoIntervencionRepository = tipoIntervencionRepository;
        }

        public TipoIntervencion CreateTipoIntervencion(TipoIntervencion tipo)
        {
            _tipoIntervencionRepository.CreateTipoIntervencion(tipo);
            return tipo;
        }

        public List<TipoIntervencion> GetTipoIntervencion()
        {
            return _tipoIntervencionRepository.GetTipoIntervencion();
        }
    }
}
