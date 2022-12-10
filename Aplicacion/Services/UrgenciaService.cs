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

        public Urgencia CreateUrgencia(Urgencia urgencia)
        {
            _urgenciaRepository.CreateUrgencia(urgencia);
            return urgencia;
        }

        public List<Urgencia> GetUrgencias()
        {
            return _urgenciaRepository.GetUrgencias();
        }
    }
}
