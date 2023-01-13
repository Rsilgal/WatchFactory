using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Intervencion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class IntervencionService : IIntervencionService
    {
        private readonly IIntervencionRepository _intervecnionRepository;

        public IntervencionService(IIntervencionRepository intervecnionRepository)
        {
            this._intervecnionRepository = intervecnionRepository;
        }

        public async Task<List<Intervencion>> CreateIntervencion(CreateIntervencionDto model)
        {
            return await _intervecnionRepository.CreateIntervencion(model);
        }

        public async Task<List<Intervencion>> DeleteIntervencion(int id)
        {
            return await _intervecnionRepository.DeleteIntervencion(id);
        }

        public async Task<List<Intervencion>> GetAllDataFromIntervenciones(int skip, int take)
        {
            return await _intervecnionRepository.GetAllDataFromIntervenciones(skip, take);
        }

        public async Task<Intervencion> GetIntervencionById(int id)
        {
            return await _intervecnionRepository.GetIntervencion(id);

        }

        public async Task<List<Intervencion>> GetIntervenciones()
        {
            return await _intervecnionRepository.GetIntervenciones();
        }

        public async Task<List<Intervencion>> GetIntervencionesByTipoIntervencion(int TipoIntervencionID)
        {
            return await _intervecnionRepository.GetIntervencionesByTipoIntervencion(TipoIntervencionID);
        }

        public async Task<List<Intervencion>> UpdateIntervencion(int id, UpdateIntervencionDto model)
        {
            return await _intervecnionRepository.UpdateIntervencion(id, model);
        }
    }
}
