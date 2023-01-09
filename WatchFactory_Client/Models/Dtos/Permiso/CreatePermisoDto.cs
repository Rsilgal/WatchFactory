using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Permiso
{
    public class CreatePermisoDto
    {
        [Required, MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
