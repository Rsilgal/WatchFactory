﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Confiiguracion
{
    public class TipoMaquina : EntidadBase<int>
    {
        /// <summary>
        /// Definición de la descripcion del tipo de máquina.
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;
    }
}
