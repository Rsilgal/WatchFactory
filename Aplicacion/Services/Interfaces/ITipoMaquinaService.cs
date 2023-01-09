using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface ITipoMaquinaService
    {
        Task<List<TipoMaquina>> GetAllTipoMaquinas();
        Task<List<TipoMaquina>> CreateTipoMaquina(TipoMaquina tipoMaquina);
    }
}
