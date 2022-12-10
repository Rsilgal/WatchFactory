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

        public EstadoIntervencion CreateEstadoIntervencion(EstadoIntervencion estado)
        {
            _estadoIntervencionRepository.CreateEstadoIntervencion(estado);
            return estado;
        }

        public List<EstadoIntervencion> GetEstadoIntervencion()
        {
            return _estadoIntervencionRepository.GetEstadoIntervencion();
        }
    }
}
