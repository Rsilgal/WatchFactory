using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly WatchFactoryDbContext _watchFactory;

        public CategoriaRepository(WatchFactoryDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Categoria>> CreateCategoria(Categoria categoria)
        {
            await _watchFactory.Categorias.AddAsync(categoria);
            await _watchFactory.SaveChangesAsync();

            return await GetCategorias();
        }

        public async Task<List<Categoria>> DeleteCategoria(Categoria categoria)
        {
            _watchFactory.Categorias.Remove(categoria);
            await _watchFactory.SaveChangesAsync();

            return await GetCategorias();
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _watchFactory.Categorias.ToListAsync();
        }

        public async Task<Categoria> GetCategorias(int id)
        {
            return await _watchFactory.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Categoria>> UpdateCategoria(int id, Categoria categoria)
        {
            var dbCategoria = await _watchFactory.Categorias.FirstOrDefaultAsync(c => categoria.Id == id);

            dbCategoria.Descripcion = categoria.Descripcion;

            return await GetCategorias();
        }
    }
}
