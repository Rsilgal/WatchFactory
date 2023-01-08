using Dominio.Modelos.Configuracion;
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
        Task<List<Zona>> CreateZona(Zona zona);
        Task<List<Zona>> UpdateZona(int id, Zona zona);
        Task<List<Zona>> DeleteZona(Zona zona);
        Task<Zona> GetZonaById(int id);
    }
}
