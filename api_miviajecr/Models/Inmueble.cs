using System;
using System.Collections.Generic;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class Inmueble
    {
        public Inmueble()
        {
            AmenidadesPorInmuebles = new HashSet<AmenidadesPorInmueble>();
            CaracteristicasInmuebles = new HashSet<CaracteristicasInmueble>();
            DisponibilidadInmuebles = new HashSet<DisponibilidadInmueble>();
            Favoritos = new HashSet<Favorito>();
            ImagenesInmuebles = new HashSet<ImagenesInmueble>();
            PoliticasPorInmuebles = new HashSet<PoliticasPorInmueble>();
            Reservaciones = new HashSet<Reservacione>();
            RestriccionesPorInmuebles = new HashSet<RestriccionesPorInmueble>();
            ServiciosPorInmuebles = new HashSet<ServiciosPorInmueble>();
            UbicacionInmuebles = new HashSet<UbicacionInmueble>();
        }

        public int IdInmueble { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoInmueble { get; set; }
        public string TituloInmueble { get; set; }
        public string DescripcionInmuebles { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public decimal PromedioCalificacion { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual TipoInmueble IdTipoInmuebleNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AmenidadesPorInmueble> AmenidadesPorInmuebles { get; set; }
        public virtual ICollection<CaracteristicasInmueble> CaracteristicasInmuebles { get; set; }
        public virtual ICollection<DisponibilidadInmueble> DisponibilidadInmuebles { get; set; }
        public virtual ICollection<Favorito> Favoritos { get; set; }
        public virtual ICollection<ImagenesInmueble> ImagenesInmuebles { get; set; }
        public virtual ICollection<PoliticasPorInmueble> PoliticasPorInmuebles { get; set; }
        public virtual ICollection<Reservacione> Reservaciones { get; set; }
        public virtual ICollection<RestriccionesPorInmueble> RestriccionesPorInmuebles { get; set; }
        public virtual ICollection<ServiciosPorInmueble> ServiciosPorInmuebles { get; set; }
        public virtual ICollection<UbicacionInmueble> UbicacionInmuebles { get; set; }
    }
}
