using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class PermisoService : IPermisoService
    {
        private readonly IPermisoRepository _permisoRepository;

        public PermisoService(IPermisoRepository permisoRepository)
        {
            _permisoRepository = permisoRepository;
        }

        public Permiso CreatePermiso(Permiso permiso)
        {
            _permisoRepository.CreatePermiso(permiso);
            return permiso;
        }

        public List<Permiso> GetPermisos()
        {
            return _permisoRepository.GetPermisos();
        }
    }
}
