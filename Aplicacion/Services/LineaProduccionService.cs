using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.LineaProduccion;
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

        public async Task<List<LineaProduccion>> CreateLineaProduccion(CreateLineaDto lineaProduccion)
        {
            return await _lineaProduccionRepository.CreateLineaProduccion(lineaProduccion); 
        }

        public async Task<List<LineaProduccion>> DeleteLinea(int id)
        {
            return await _lineaProduccionRepository.DeleteLineaProduccion(id);
        }

        public async Task<List<LineaProduccion>> GetAllLineasProduccion()
        {
            return await _lineaProduccionRepository.GetAllLineasProduccion();
        }

        public async Task<LineaProduccion> GetLineaById(int id)
        {
            return await _lineaProduccionRepository.GetLineaProduccionById(id);
        }

        public async Task<List<LineaProduccion>> UpdateLinea(int id, UpdateLineaDto model)
        {
            return await _lineaProduccionRepository.UpdateLineaProduccion(id, model);
        }
    }
}
