using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Categoria;
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
        Task<List<Categoria>> CreateCategoria(CreateCategoriaDto categoria);
        Task<List<Categoria>> UpdateCategoria(int id, UpdateCategoriaDto categoria);
        Task<List<Categoria>> DeleteCategoria(Categoria categoria);
        Task<Categoria> GetCategoriaById(int id);
    }
}
