using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetRols();
        Task<List<Rol>> CreateRol(Rol rol);
        Task<List<Rol>> UpdateRol(int id, Rol rol);
        Task<List<Rol>> DeleteRol(Rol rol);
        Task<Rol> GetRolById(int id);
    }
}
