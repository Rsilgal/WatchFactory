using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Maquina;
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

        public async Task<List<Maquina>> CreateMaquina(CreateMaquinaDto maquina)
        {
            return await _maquinaRepository.CreateMaquina(maquina);
        }

        public async Task<List<Maquina>> DeleteMaquina(int id)
        {
            return await _maquinaRepository.DeleteMaquina(id);
        }

        public async Task<List<Maquina>> GetAllMaquinas()
        {
            return await _maquinaRepository.GetAllMaquinas();
        }

        public async Task<Maquina> GetMaquinaById(int id)
        {
            return await _maquinaRepository.GetMaquinaById(id);
        }

        public async Task<List<Maquina>> GettAllDataFromMaquina(int skip, int take)
        {
            return await _maquinaRepository.GetAllDataFromMaquina(skip, take);
        }

        public async Task<List<Maquina>> UpdateMaquina(int id, UpdateMaquinaDto model)
        {
            return await _maquinaRepository.UpdateMaquina(id, model);
        }
    }
}
