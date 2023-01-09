﻿using Aplicacion.Repository;
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

        public async Task<List<Rol>> CreateRol(Rol rol)
        {
            return await _rolRepository.CreateRol(rol);
        }

        public async Task<List<Rol>> GetRols()
        {
            return await _rolRepository.GetRols();
        }
    }
}
