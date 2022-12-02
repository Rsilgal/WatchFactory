using Dominio.Modelos.Confiiguracion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface ITipoMaquinaDBContext
    {
        DbSet<TipoMaquina> TipoMaquinas { get; set; }
        Task<List<TipoMaquina>> TipoMaquinasAsync();
        Task<TipoMaquina> TipoMaquinasAsyncById(int id);
        Task<TipoMaquina> AddTipoMaquinaAsync(TipoMaquina tipoMaquina);
        Task<TipoMaquina> RemoveTipoMaquinaAsync(TipoMaquina tipoMaquina);
        Task<TipoMaquina> UpdateTipoMaquinaAsync(TipoMaquina tipoMaquina);
    }
}
