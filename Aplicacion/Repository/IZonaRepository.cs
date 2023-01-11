using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Dtos.Zona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repository
{
    public interface IZonaRepository
    {
        Task<List<Zona>> GetZonas();
        Task<List<Zona>> CreateZona(CreateZonaDto dto);
        Task<List<Zona>> UpdateZona(int id, UpdateZonaDto dto);
        Task<List<Zona>> DeleteZona(int id);
        Task<Zona> GetZonaById(int id);
        Task<List<Zona>> GetAllDataFromZona(int skip, int take);
    }
}
