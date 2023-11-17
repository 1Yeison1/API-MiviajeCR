﻿using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Restriccione
    {
        public Restriccione()
        {
            RestriccionesPorInmuebles = new HashSet<RestriccionesPorInmueble>();
        }

        public int IdRestriccion { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<RestriccionesPorInmueble> RestriccionesPorInmuebles { get; set; }
    }
}