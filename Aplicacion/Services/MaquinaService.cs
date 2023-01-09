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

        public async Task<List<Maquina>> CreateMaquina(Maquina maquina)
        {
            return await _maquinaRepository.CreateMaquina(maquina);
        }

        public async Task<List<Maquina>> GetAllMaquinas()
        {
            return await _maquinaRepository.GetAllMaquinas();
        }
    }
}
