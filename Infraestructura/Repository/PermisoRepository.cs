using Aplicacion.Repository;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class PermisoRepository : IPermisoRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public PermisoRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public Permiso CreatePermiso(Permiso permiso)
        {
            throw new NotImplementedException();
        }

        public List<Permiso> GetPermisos()
        {
            throw new NotImplementedException();
        }
    }
}
