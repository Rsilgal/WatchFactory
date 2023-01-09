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

        public async Task<List<TipoIntervencion>> CreateTipoIntervencion(TipoIntervencion tipo)
        {
            return await _tipoIntervencionRepository.CreateTipoIntervencion(tipo);
        }

        public async Task<List<TipoIntervencion>> GetTipoIntervencion()
        {
            return await _tipoIntervencionRepository.GetTipoIntervencion();
        }
    }
}
