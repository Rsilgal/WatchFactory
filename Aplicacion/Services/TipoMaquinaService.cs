using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.TipoMaquina;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class TipoMaquinaService : ITipoMaquinaService
    {
        private readonly ITipoMaquinaRepository _tipoMaquinaRepository;
        public TipoMaquinaService(ITipoMaquinaRepository tipoMaquinaRepository) 
        {
            _tipoMaquinaRepository= tipoMaquinaRepository;
        }

        public async Task<List<TipoMaquina>> CreateTipoMaquina(CreateTipoMaquinaDto model)
        {
            return await _tipoMaquinaRepository.CreateTipoMaquina(model);
            
        }

        public async Task<List<TipoMaquina>> DeleteTipoMaquina(int id)
        {
            return await _tipoMaquinaRepository.DeleteTipoMaquina(id);
        }

        public async Task<List<TipoMaquina>> GetAllTipoMaquinas()
        {
            return await _tipoMaquinaRepository.GetAllTipoMaquinas();
        }

        public async Task<TipoMaquina> GetTipoMaquinaById(int id)
        {
            return await _tipoMaquinaRepository.GetTipoMaquinaById(id);
        }

        public async Task<List<TipoMaquina>> UpdateTipoMaquina(int id, UpdateTipoMaquinaDto model)
        {
            return await _tipoMaquinaRepository.UpdateTipoMaquina(id, model);
        }
    }
}
