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

        public Categoria CreateCategoria(Categoria categoria)
        {
            _categoriaRepository.CreateCategoria(categoria);
            return categoria;
        }

        public List<Categoria> GetCategorias()
        {
            return _categoriaRepository.GetCategorias();
        }
    }
}
