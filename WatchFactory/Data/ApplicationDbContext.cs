using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Intervencion;
using Dominio.Modelos.Nucleo;
using Dominio.Modelos.Usuarios;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WatchFactory.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add WathFactoryDBContext
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
    }
}