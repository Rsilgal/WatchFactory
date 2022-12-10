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

        public Zona CreateZona(Zona zona)
        {
            _zonaRepository.CreateZona(zona);
            return zona;
        }

        public List<Zona> GetZonas()
        {
            return _zonaRepository.GetZonas();
        }
    }
}
