﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Usuarios
{
    public class PermisoRol: EntidadBase<int>
    {
        public int PermisoID { get; set; }
        public int RolID { get; set; }
        
    }
}
