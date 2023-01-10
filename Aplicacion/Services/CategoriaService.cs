using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<List<Categoria>> CreateCategoria(CreateCategoriaDto categoria)
        {
            return await _categoriaRepository.CreateCategoria(categoria);
        }

        public async Task<Categoria> GetCategoriaById(int id)
        {
            return await _categoriaRepository.GetCategoriaById(id);
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _categoriaRepository.GetCategorias();
        }

        public async Task<List<Categoria>> UpdateCategoria(int id, UpdateCategoriaDto categoria)
        {
            return await _categoriaRepository.UpdateCategoria(id, categoria);
        }
    }
}
