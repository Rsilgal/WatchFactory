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
    public class ZonaService : IZonaService
    {
        private readonly IZonaRepository _zonaRepository;

        public ZonaService(IZonaRepository zonaRepository) 
        {
            _zonaRepository = zonaRepository;
        }

        public async Task<List<Zona>> CreateZona(Zona zona)
        {
            return await _zonaRepository.CreateZona(zona);
            
        }

        public async Task<List<Zona>> GetZonas()
        {
            return await _zonaRepository.GetZonas();
        }
    }
}
