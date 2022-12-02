using Dominio.Modelos.Confiiguracion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface ILineaProduccionDBContext
    {
        DbSet<LineaProduccion> lineaProduccion { get; set; }
        Task<List<LineaProduccion>> GetLineaProduccionAsync();
        Task<LineaProduccion> GetLineaProduccionByIdAsync(int id);
        Task<LineaProduccion> AddFabricaAsync(Fabrica fabrica);
        Task<LineaProduccion> RemoveFabricaAsync(Fabrica fabrica);
        Task<LineaProduccion> UpdateLineaProduccionAsync(LineaProduccion lineaProduccion);

    }
}
