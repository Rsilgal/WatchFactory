using Dominio.Modelos.Confiiguracion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IFabricaDBContext
    {
        DbSet<Fabrica> Fabricas { get; set; }
        Task<List<Fabrica>> GetFabricaAsync();
        Task<Fabrica> GetFabricaByIdAsync(int id);
        Task<Fabrica> AddFabricaAsync(Fabrica fabrica);
        Task<Fabrica> DeleteFabricaAsync(Fabrica fabrica);
        Task<Fabrica> UpdateFabricaAsync(Fabrica fabrica);
    }
}
