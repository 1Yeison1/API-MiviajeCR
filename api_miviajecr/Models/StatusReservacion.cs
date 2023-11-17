using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class StatusReservacion
    {
        public StatusReservacion()
        {
            Reservaciones = new HashSet<Reservacione>();
        }

        public int IdStatusReservacion { get; set; }
        public string StatusReservacion1 { get; set; }
        public bool EstaActivo { get; set; }

        public virtual ICollection<Reservacione> Reservaciones { get; set; }
    }
}
