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
    public class LineaProduccionService : ILinneaProduccionService
    {
        private readonly ILineaProduccionRepository _lineaProduccionRepository;

        public LineaProduccionService(ILineaProduccionRepository lineaProduccionRepository)
        {
            _lineaProduccionRepository = lineaProduccionRepository;
        }

        public LineaProduccion CreateLineaProduccion(LineaProduccion lineaProduccion)
        {
            _lineaProduccionRepository.CreateLineaProduccion(lineaProduccion); 
            return lineaProduccion;
        }

        public List<LineaProduccion> GetAllLineasProduccion()
        {
            return _lineaProduccionRepository.GetAllLineasProduccion();
        }
    }
}
