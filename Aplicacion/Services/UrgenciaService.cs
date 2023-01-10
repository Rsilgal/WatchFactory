using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Urgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class UrgenciaService : IUrgenciaService
    {
        private readonly IUrgenciaRepository _urgenciaRepository;

        public UrgenciaService(IUrgenciaRepository urgenciaRepository)
        {
            _urgenciaRepository = urgenciaRepository;
        }

        public async Task<List<Urgencia>> CreateUrgencia(CreateUrgenciaDto dto)
        {
            
            return await _urgenciaRepository.CreateUrgencia(dto);
        }

        public async Task<List<Urgencia>> DeleteUrgencia(int id)
        {
            return await _urgenciaRepository.DeleteUrgencia(id);
        }

        public async Task<Urgencia> GetUrgenciaById(int id)
        {
            return await _urgenciaRepository.GetUrgenciaById(id);
        }

        public async Task<List<Urgencia>> GetUrgencias()
        {
            return await _urgenciaRepository.GetUrgencias();
        }

        public async Task<List<Urgencia>> UpdateUrgencia(int id, UpdateUrgenciaDto dto)
        {
            return await _urgenciaRepository.UpdateUrgencia(id, dto);
        }
    }
}
