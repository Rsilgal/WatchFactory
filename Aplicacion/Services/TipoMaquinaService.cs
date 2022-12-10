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
    public class TipoMaquinaService : ITipoMaquinaService
    {
        private readonly ITipoMaquinaRepository _tipoMaquinaRepository;
        public TipoMaquinaService(ITipoMaquinaRepository tipoMaquinaRepository) 
        {
            _tipoMaquinaRepository= tipoMaquinaRepository;
        }

        public TipoMaquina CreateTipoMaquina(TipoMaquina tipoMaquina)
        {
            _tipoMaquinaRepository.CreateTipoMaquina(tipoMaquina);
            return tipoMaquina;
        }

        public List<TipoMaquina> GetAllTipoMaquinas()
        {
            return _tipoMaquinaRepository.GetAllTipoMaquinas();
        }
    }
}
