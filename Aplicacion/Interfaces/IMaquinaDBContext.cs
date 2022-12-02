using Dominio.Modelos.Confiiguracion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IMaquinaDBContext
    {
        DbSet<Maquina> Maquinas { get; set; }
        Task<List<Maquina>> GetMaquinas();
        Task<Maquina> GetMaquinaById(int id);
        Task<Maquina> AddMaquina(Maquina maquina);
        Task<Maquina> RemoveMaquina(Maquina maquina);
        Task<Maquina> UpdateMaquina(Maquina maquina);
    }
}
