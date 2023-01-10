using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Dtos.Rol;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public async Task<List<Rol>> CreateRol(CreateRolDto model)
        {
            return await _rolRepository.CreateRol(model);
        }

        public async Task<List<Rol>> DeleteRol(int id)
        {
            return await _rolRepository.DeleteRol(id);
        }

        public async Task<Rol> GetRolById(int id)
        {
            return await _rolRepository.GetRolById(id);
        }

        public async Task<List<Rol>> GetRols()
        {
            return await _rolRepository.GetRols();
        }

        public async Task<List<Rol>> UpdateRol(int id, UpdateRolDto model)
        {
            return await _rolRepository.UpdateRol(id, model);
        }
    }
}
