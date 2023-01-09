﻿using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.Nucleo
{
    public class Ticket : EntidadBase<int>
    {
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCierre { get; set; }
        
        public int MaquinaID { get; set; }
        
        public int CategoriaID { get; set; }
        
        public int UsuarioID { get; set; }
        
        public int UrgenciaID { get; set; }
        
        public int ZonaID { get; set; }
        
        public string Estado { get; set; }
        
        public Maquina Maquina { get; set; }
        
        public Categoria Categoria { get; set; }
        
        public Usuario Usuario { get; set; }
        
        public Urgencia Urgencia { get; set; }
        
        public Zona Zona { get; set; }

        public IEnumerable<Intervencion.Intervencion> Intervenciones { get; set; }

    }
}
