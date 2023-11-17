using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Reservacione
    {
        public Reservacione()
        {
            CalificacionReservaciones = new HashSet<CalificacionReservacione>();
            Denuncia = new HashSet<Denuncia>();
            HistoricoLugaresVisitados = new HashSet<HistoricoLugaresVisitado>();
            ReservacionCheckIns = new HashSet<ReservacionCheckIn>();
            ReservacionCheckOuts = new HashSet<ReservacionCheckOut>();
        }

        public int IdReservacion { get; set; }
        public int IdInmueble { get; set; }
        public int IdUsuario { get; set; }
        public int IdStatusReservacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal? MontoDescuento { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Inmueble IdInmuebleNavigation { get; set; }
        public virtual StatusReservacion IdStatusReservacionNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<CalificacionReservacione> CalificacionReservaciones { get; set; }
        public virtual ICollection<Denuncia> Denuncia { get; set; }
        public virtual ICollection<HistoricoLugaresVisitado> HistoricoLugaresVisitados { get; set; }
        public virtual ICollection<ReservacionCheckIn> ReservacionCheckIns { get; set; }
        public virtual ICollection<ReservacionCheckOut> ReservacionCheckOuts { get; set; }
    }
}
