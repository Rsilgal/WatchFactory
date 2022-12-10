using Aplicacion.Repository;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class RolRepository : IRolRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public RolRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public Rol CreateRol(Rol rol)
        {
            throw new NotImplementedException();
        }

        public List<Rol> GetRols()
        {
            throw new NotImplementedException();
        }
    }
}
