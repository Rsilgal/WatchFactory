using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
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

        public async Task<List<TipoMaquina>> CreateTipoMaquina(TipoMaquina tipoMaquina)
        {
            return await _tipoMaquinaRepository.CreateTipoMaquina(tipoMaquina);
            
        }

        public async Task<List<TipoMaquina>> GetAllTipoMaquinas()
        {
            return await _tipoMaquinaRepository.GetAllTipoMaquinas();
        }
    }
}
