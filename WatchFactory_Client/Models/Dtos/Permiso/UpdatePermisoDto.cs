using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Permiso
{
    public class UpdatePermisoDto
    {
        [Required, MinLength(1), MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
