using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            ServiciosPorInmuebles = new HashSet<ServiciosPorInmueble>();
        }

        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<ServiciosPorInmueble> ServiciosPorInmuebles { get; set; }
    }
}
