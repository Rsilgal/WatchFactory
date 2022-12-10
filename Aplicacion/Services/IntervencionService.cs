using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Intervencion;
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

        public Intervencion CreateIntervencion(Intervencion intervencion)
        {
            _intervecnionRepository.CreateIntervencion(intervencion);
            return intervencion;
        }

        public Intervencion DeleteIntervencion(Intervencion intervencion)
        {
            return _intervecnionRepository.DeleteIntervencion(intervencion);
        }

        public Intervencion GetIntervencion(int id)
        {
            return _intervecnionRepository.GetIntervencion(id);
        }

        public List<Intervencion> GetIntervenciones()
        {
            return _intervecnionRepository.GetIntervenciones();
        }

        public Intervencion UpdateIntervencion(Intervencion newIntervencion)
        {
            return _intervecnionRepository.UpdateIntervencion(newIntervencion);
        }
    }
}
