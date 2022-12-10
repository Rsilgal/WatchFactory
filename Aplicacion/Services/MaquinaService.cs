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
    internal class MaquinaService : IMaquinaService
    {
        private readonly IMaquinaRepository _maquinaRepository;
        public MaquinaService(IMaquinaRepository maquinaRepository)
        {
            _maquinaRepository = maquinaRepository;
        }

        public Maquina CreateMaquina(Maquina maquina)
        {
            _maquinaRepository.CreateMaquina(maquina);
            return maquina;
        }

        public List<Maquina> GetAllMaquinas()
        {
            return _maquinaRepository.GetAllMaquinas();
        }
    }
}
