using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
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

        public async Task<List<Categoria>> CreateCategoria(Categoria categoria)
        {
            return await _categoriaRepository.CreateCategoria(categoria);
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _categoriaRepository.GetCategorias();
        }
    }
}
