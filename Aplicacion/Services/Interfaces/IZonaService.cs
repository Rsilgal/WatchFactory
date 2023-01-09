﻿using Dominio.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Interfaces
{
    public interface IZonaService
    {
        Task<List<Zona>> GetZonas();
        Task<List<Zona>> CreateZona(Zona zona);
    }
}
