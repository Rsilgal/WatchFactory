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
    public class UrgenciaService : IUrgenciaService
    {
        private readonly IUrgenciaRepository _urgenciaRepository;

        public UrgenciaService(IUrgenciaRepository urgenciaRepository)
        {
            _urgenciaRepository = urgenciaRepository;
        }

        public async Task<List<Urgencia>> CreateUrgencia(Urgencia urgencia)
        {
            
            return await _urgenciaRepository.CreateUrgencia(urgencia);
        }

        public async Task<List<Urgencia>> GetUrgencias()
        {
            return await _urgenciaRepository.GetUrgencias();
        }
    }
}
