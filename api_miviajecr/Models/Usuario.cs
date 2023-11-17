using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            CalificacionReservaciones = new HashSet<CalificacionReservacione>();
            CalificacionUsuarioIdUsuarioCalificadoNavigations = new HashSet<CalificacionUsuario>();
            CalificacionUsuarioIdUsuarioCalificadorNavigations = new HashSet<CalificacionUsuario>();
            CuentasBancaria = new HashSet<CuentasBancaria>();
            Denuncia = new HashSet<Denuncia>();
            Favoritos = new HashSet<Favorito>();
            HistoricoLugaresVisitados = new HashSet<HistoricoLugaresVisitado>();
            Inmuebles = new HashSet<Inmueble>();
            Reservaciones = new HashSet<Reservacione>();
        }

        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefono { get; set; }
        public string Contraseña { get; set; }
        public string FotoIdentificacion { get; set; }
        public decimal PromedioCalificacion { get; set; }
        public bool SesionActiva { get; set; }
        public string Token { get; set; }
        public bool EstaActivo { get; set; }
        public bool FueValidado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<CalificacionReservacione> CalificacionReservaciones { get; set; }
        public virtual ICollection<CalificacionUsuario> CalificacionUsuarioIdUsuarioCalificadoNavigations { get; set; }
        public virtual ICollection<CalificacionUsuario> CalificacionUsuarioIdUsuarioCalificadorNavigations { get; set; }
        public virtual ICollection<CuentasBancaria> CuentasBancaria { get; set; }
        public virtual ICollection<Denuncia> Denuncia { get; set; }
        public virtual ICollection<Favorito> Favoritos { get; set; }
        public virtual ICollection<HistoricoLugaresVisitado> HistoricoLugaresVisitados { get; set; }
        public virtual ICollection<Inmueble> Inmuebles { get; set; }
        public virtual ICollection<Reservacione> Reservaciones { get; set; }
    }
}
