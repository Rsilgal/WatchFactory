using Dominio.Modelos.Configuracion;
using Dominio.Modelos.Usuarios;

namespace WatchFactory_Client.Services.Interfaces
{
    public interface IConfiguracionService
    {
        List<Fabrica> Fabricas { get; set; }
        List<LineaProduccion> Lineas { get; set; }
        List<Maquina> Maquinas { get; set; }
        List<Categoria> Categorias { get; set; }
        List<Usuario> Usuarios { get; set; }
        List<Urgencia> Urgencias { get; set; }
        List<Zona> Zonas { get; set; }
        List<EstadoIntervencion> Estados { get; set; }

        Task GetFabricas();
        Task GetLineas();
        Task GetMaquinas();
        Task GetCategorias();
        Task GetUsuarios();
        Task GetUrgencias();
        Task GetZonas();
        Task GetEstados();
    }
}
