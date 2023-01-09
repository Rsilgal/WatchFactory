﻿using System.ComponentModel.DataAnnotations;

namespace WatchFactory_Client.Models.Dtos.Urgencia
{
    public class CreateUrgenciaDto
    {
        [Required, MinLength(1)]
        public string Descripcion { get; set; }
    }
}
