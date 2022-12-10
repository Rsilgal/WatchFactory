using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class UrgenciaRepository : IUrgenciaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public UrgenciaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public Urgencia CreateUrgencia(Urgencia urgencia)
        {
            throw new NotImplementedException();
        }

        public List<Urgencia> GetUrgencias()
        {
            throw new NotImplementedException();
        }
    }
}
