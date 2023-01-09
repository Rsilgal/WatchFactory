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
        Task<List<Rol>> CreateRol(Rol rol);
    }
}
