using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ServicesPages.Interfaces
{
    public interface IEmpresaServicePages
    {
        Empresa Empresa { get; set; }
        List<EstadoIntervencion> Estados { get; set; }
        Task UpdateCompanyData(Empresa empresa);
        Task GetEmpresa();
        Task GetEstadosIntervenciones();
        Task<string> GetNombre();
    }
}
