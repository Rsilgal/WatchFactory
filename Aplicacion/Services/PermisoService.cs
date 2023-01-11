using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Permiso;
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

        public async Task<List<Permiso>> CreatePermiso(CreatePermisoDto model)
        {
            return await _permisoRepository.CreatePermiso(model);
        }

        public async Task<List<Permiso>> DeletePermiso(int id)
        {
            return await _permisoRepository.DeletePermiso(id);
        }

        public async Task<List<Permiso>> GetAllDataFromPermisos(int skip, int take)
        {
            return await _permisoRepository.GetAllDataFromPermisos( skip,  take);
        }

        public async Task<Permiso> GetPermisoById(int id)
        {
            return await _permisoRepository.GetPermisoById(id);
        }

        public async Task<List<Permiso>> GetPermisos()
        {
            return await _permisoRepository.GetPermisos();
        }

        public async Task<List<Permiso>> UpdatePermiso(int id, UpdatePermisoDto model)
        {
            return await _permisoRepository.UpdatePermiso(id, model);
        }
    }
}
