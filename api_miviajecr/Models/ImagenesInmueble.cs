﻿using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class ImagenesInmueble
    {
        public int IdImagen { get; set; }
        public int IdInmueble { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

       
    }
}
