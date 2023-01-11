using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Zona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class ZonaService : IZonaService
    {
        private readonly IZonaRepository _zonaRepository;

        public ZonaService(IZonaRepository zonaRepository) 
        {
            _zonaRepository = zonaRepository;
        }

        public async Task<List<Zona>> CreateZona(CreateZonaDto dto)
        {
            return await _zonaRepository.CreateZona(dto);
            
        }

        public async Task<List<Zona>> DeleteZona(int id)
        {
            return await _zonaRepository.DeleteZona(id);
        }

        public async Task<List<Zona>> GetAllDataFromZona(int skip, int take)
        {
            return await _zonaRepository.GetAllDataFromZona(skip, take);
        }

        public async Task<Zona> GetZonaById(int id)
        {
            return await _zonaRepository.GetZonaById(id);
        }

        public async Task<List<Zona>> GetZonas()
        {
            return await _zonaRepository.GetZonas();
        }

        public async Task<List<Zona>> UpdateZona(int id, UpdateZonaDto dto)
        {
            return await _zonaRepository.UpdateZona(id, dto);
        }
    }
}
