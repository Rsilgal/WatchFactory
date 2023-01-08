using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using Dominio.Modelos.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class WatchFactoryDbContext : DbContext
    {
        public WatchFactoryDbContext(DbContextOptions<WatchFactoryDbContext> options)
            :base(options)
        {

        }

        public DbSet<Fabrica> Fabricas { get; set; }
        public DbSet<LineaProduccion> Lineas { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<TipoMaquina> TipoMaquinas { get; set; }
        public DbSet<Urgencia> Urgencias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<EstadoIntervencion> EstadoIntervenciones { get; set; }
        public DbSet<TipoIntervencion> TipoIntervenciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Intervencion> Intervenciones { get; set; }
        public DbSet<Zona> Zonas { get; set; }

        // Tablas sin relacion directa con el núcleo del sistema

        //public DbSet<Auditoria> Auditorias { get; set; }
        //public DbSet<Empresa> Empresas { get; set; }
        //public DbSet<Estadistica> Estadisticas { get; set; }
        //public DbSet<Notificacion> Notificaciones { get; set; }
        //public DbSet<Reporte> Reportes { get; set; }
    }
}
