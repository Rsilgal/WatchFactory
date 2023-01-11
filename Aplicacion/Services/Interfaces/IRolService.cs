using Dominio.Modelos.Dtos.Rol;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IRolService
    {
        Task<List<Rol>> GetRols();
        Task<List<Rol>> CreateRol(CreateRolDto model);
        Task<List<Rol>> UpdateRol(int id, UpdateRolDto model);
        Task<List<Rol>> DeleteRol(int id);
        Task<Rol> GetRolById(int id);
        Task<List<Rol>> GetAllDataFromRol(int skip, int take);
    }
}
