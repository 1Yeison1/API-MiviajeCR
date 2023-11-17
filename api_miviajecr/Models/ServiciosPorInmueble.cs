﻿using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class ServiciosPorInmueble
    {
        public int IdServicio { get; set; }
        public int IdInmuebles { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdServiciosPorInmueble { get; set; }

        public virtual Inmueble IdInmueblesNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
    }
}
