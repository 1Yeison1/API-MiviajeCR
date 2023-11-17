using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Amenidade
    {
        public Amenidade()
        {
            AmenidadesPorInmuebles = new HashSet<AmenidadesPorInmueble>();
        }

        public int IdAmenidad { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<AmenidadesPorInmueble> AmenidadesPorInmuebles { get; set; }
    }
}
