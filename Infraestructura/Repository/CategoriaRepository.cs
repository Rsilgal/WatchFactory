using Aplicacion.Repository;
using Dominio.Modelos.Configuracion;
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
            this._watchFactory = watchFactory;
        }

        public Categoria CreateCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
