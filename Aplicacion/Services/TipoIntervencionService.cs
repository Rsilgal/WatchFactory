using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoIntervencion;
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

        public async Task<List<TipoIntervencion>> CreateTipoIntervencion(CreateTipoIntervencionDto model)
        {
            return await _tipoIntervencionRepository.CreateTipoIntervencion(model);
        }

        public async Task<List<TipoIntervencion>> DeleteTipoIntervencion(int id)
        {
            return await _tipoIntervencionRepository.DeleteTipoIntervencion(id);
        }

        public async Task<TipoIntervencion> GetTipoIntervecionById(int id)
        {
            return await _tipoIntervencionRepository.GetTipoIntervencionById(id);
        }

        public async Task<List<TipoIntervencion>> GetTipoIntervencion()
        {
            return await _tipoIntervencionRepository.GetTipoIntervencion();
        }

        public async Task<List<TipoIntervencion>> UpdateTipoIntervecion(int id, UpdateTipoIntervencionDto model)
        {
            return await _tipoIntervencionRepository.UpdateTipoIntervencion(id, model);
        }
    }
}
