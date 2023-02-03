using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Categoria;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchFactory.Data;

namespace WatchFactory.Data.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _watchFactory;

        public CategoriaRepository(ApplicationDbContext watchFactory)
        {
            _watchFactory = watchFactory;
        }

        public async Task<List<Categoria>> CreateCategoria(CreateCategoriaDto model)
        {
            await _watchFactory.Categorias.AddAsync(new Categoria
            {
                Descripcion= model.Descripcion,
            });
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

        public async Task<Categoria> GetCategoriaById(int id)
        {
            return await _watchFactory.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Categoria>> UpdateCategoria(int id, UpdateCategoriaDto model)
        {
            var dbCategoria = await _watchFactory.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            dbCategoria.Descripcion = model.Descripcion;

            await _watchFactory.SaveChangesAsync();

            return await GetCategorias();
        }
    }
}
