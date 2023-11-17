using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Politica
    {
        public Politica()
        {
            PoliticasPorInmuebles = new HashSet<PoliticasPorInmueble>();
        }

        public int IdPolitica { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<PoliticasPorInmueble> PoliticasPorInmuebles { get; set; }
    }
}
