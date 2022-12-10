using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class TipoMaquinaRepository : ITipoMaquinaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public TipoMaquinaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public TipoMaquina CreateTipoMaquina(TipoMaquina tipoMaquina)
        {
            throw new NotImplementedException();
        }

        public List<TipoMaquina> GetAllTipoMaquinas()
        {
            throw new NotImplementedException();
        }
    }
}
