using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetCategorias();
        Task<List<Categoria>> CreateCategoria(Categoria categoria);
        Task<List<Categoria>> UpdateCategoria(int id, Categoria categoria);
        Task<List<Categoria>> DeleteCategoria(Categoria categoria);
        Task<Categoria> GetCategorias(int id);
    }
}
