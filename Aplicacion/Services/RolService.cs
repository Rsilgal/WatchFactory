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
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public Rol CreateRol(Rol rol)
        {
            return _rolRepository.CreateRol(rol);
        }

        public List<Rol> GetRols()
        {
            return _rolRepository.GetRols();
        }
    }
}
