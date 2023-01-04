using Dominio.Modelos.Configuracion;
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
        public int MaquinaID { get; set; }
        public int CategoriaID { get; set; }
        public int UsuarioID { get; set; }
        public int UrgenciaID { get; set; }
        public int ZonaID { get; set; }
        public string Estado { get; set; }

        [ForeignKey("MaquinaID")]
        public virtual Maquina Maquina { get; set; }
        [ForeignKey("CategoriaID")]
        public virtual Categoria Categoria { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuario  Usuario { get; set; }
        [ForeignKey("UrgenciaID")]
        public virtual Urgencia Urgencia { get; set; }
        [ForeignKey("ZonaID")]
        public virtual Zona Zona { get; set; }

        public Ticket(string descripcion, int maquinaID, int categoriaID, int usuarioID, int urgenciaID, int zonaID)
        {
            Descripcion = descripcion;
            MaquinaID = maquinaID;
            CategoriaID = categoriaID;
            UsuarioID = usuarioID;
            UrgenciaID = urgenciaID;
            ZonaID = zonaID;
        }
    }
}
