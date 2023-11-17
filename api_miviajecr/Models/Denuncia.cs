using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Denuncia
    {
        public int IdDenuncia { get; set; }
        public int IdReservacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdStatusDenuncia { get; set; }
        public string Denuncia1 { get; set; }
        public string Solucion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Reservacione IdReservacionNavigation { get; set; }
        public virtual StatusDenuncium IdStatusDenunciaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
