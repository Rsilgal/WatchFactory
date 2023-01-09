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
    public class EstadoIntervecionService : IEstadoIntervencionService
    {
        private readonly IEstadoIntervencionRepository _estadoIntervencionRepository;

        public EstadoIntervecionService(IEstadoIntervencionRepository estadoIntervencionRepository)
        {
            this._estadoIntervencionRepository = estadoIntervencionRepository;
        }

        public async Task<List<EstadoIntervencion>> CreateEstadoIntervencion(EstadoIntervencion estado)
        {
            return await _estadoIntervencionRepository.CreateEstadoIntervencion(estado);
        }

        public async Task<List<EstadoIntervencion>> GetEstadoIntervencion()
        {
            return await _estadoIntervencionRepository.GetEstadoIntervencion();
        }
    }
}
