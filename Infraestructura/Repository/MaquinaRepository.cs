using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class MaquinaRepository : IMaquinaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;
        public MaquinaRepository(WatchFactoryDbContext watchFactory) 
        {
            _watchFactory= watchFactory;
        }

        public Maquina CreateMaquina(Maquina maquina)
        {
            throw new NotImplementedException();
        }

        public List<Maquina> GetAllMaquinas()
        {
            throw new NotImplementedException();
        }
    }
}
