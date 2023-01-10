using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetCategorias();
        Task<List<Categoria>> CreateCategoria(CreateCategoriaDto categoria);
        Task<Categoria> GetCategoriaById(int id);
        Task<List<Categoria>> UpdateCategoria(int id, UpdateCategoriaDto categoria);
    }
}
