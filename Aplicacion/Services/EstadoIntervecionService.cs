using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.EstadoIIntervencion;
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

        public async Task<List<EstadoIntervencion>> CreateEstadoIntervencion(CreateEstadoIntervencionDto model)
        {
            return await _estadoIntervencionRepository.CreateEstadoIntervencion(model);
        }

        public async Task<List<EstadoIntervencion>> DeleteEstadoIntervencion(int id)
        {
            return await _estadoIntervencionRepository.DeleteEstadoIntervencion(id);
        }

        public async Task<List<EstadoIntervencion>> GetEstadoIntervencion()
        {
            return await _estadoIntervencionRepository.GetEstadoIntervencion();
        }

        public async Task<EstadoIntervencion> GetEstadoIntervencionById(int id)
        {
            return await _estadoIntervencionRepository.GetEstadoIntervencionById(id);
        }

        public async Task<List<EstadoIntervencion>> UpdateEstadoIntervencion(int id, UpdateEstadoIntervencionDto model)
        {
            return await _estadoIntervencionRepository.UpdateEstadoIntervencion(id, model);
        }
    }
}
