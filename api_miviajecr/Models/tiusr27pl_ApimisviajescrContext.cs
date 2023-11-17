using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace api_miviajecr.Models
{
    public partial class tiusr27pl_ApimisviajescrContext : DbContext
    {
        public tiusr27pl_ApimisviajescrContext()
        {
        }

        public tiusr27pl_ApimisviajescrContext(DbContextOptions<tiusr27pl_ApimisviajescrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Amenidade> Amenidades { get; set; }
        public virtual DbSet<AmenidadesPorInmueble> AmenidadesPorInmuebles { get; set; }
        public virtual DbSet<CalificacionReservacione> CalificacionReservaciones { get; set; }
        public virtual DbSet<CalificacionUsuario> CalificacionUsuarios { get; set; }
        public virtual DbSet<CaracteristicasInmueble> CaracteristicasInmuebles { get; set; }
        public virtual DbSet<CuentasBancaria> CuentasBancarias { get; set; }
        public virtual DbSet<Denuncia> Denuncias { get; set; }
        public virtual DbSet<DisponibilidadInmueble> DisponibilidadInmuebles { get; set; }
        public virtual DbSet<Favorito> Favoritos { get; set; }
        public virtual DbSet<HistoricoLugaresVisitado> HistoricoLugaresVisitados { get; set; }
        public virtual DbSet<ImagenesInmueble> ImagenesInmuebles { get; set; }
        public virtual DbSet<Inmueble> Inmuebles { get; set; }
        public virtual DbSet<Politica> Politicas { get; set; }
        public virtual DbSet<PoliticasPorInmueble> PoliticasPorInmuebles { get; set; }
        public virtual DbSet<ReservacionCheckIn> ReservacionCheckIns { get; set; }
        public virtual DbSet<ReservacionCheckOut> ReservacionCheckOuts { get; set; }
        public virtual DbSet<Reservacione> Reservaciones { get; set; }
        public virtual DbSet<Restriccione> Restricciones { get; set; }
        public virtual DbSet<RestriccionesPorInmueble> RestriccionesPorInmuebles { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<ServiciosPorInmueble> ServiciosPorInmuebles { get; set; }
        public virtual DbSet<StatusDenuncium> StatusDenuncia { get; set; }
        public virtual DbSet<StatusReservacion> StatusReservacions { get; set; }
        public virtual DbSet<TipoInmueble> TipoInmuebles { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<TiposTransaccion> TiposTransaccions { get; set; }
        public virtual DbSet<Transaccione> Transacciones { get; set; }
        public virtual DbSet<UbicacionInmueble> UbicacionInmuebles { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tiusr26pl.cuc-carrera-ti.ac.cr\\MSSQLSERVER2019;Database=tiusr27pl_Apimisviajescr;Persist Security Info=True;User ID=viajescr;Password=misviajescr;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("viajescr");

            modelBuilder.Entity<Amenidade>(entity =>
            {
                entity.HasKey(e => e.IdAmenidad)
                    .HasName("PK__Amenidad__D27CA7D5089CC51B");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<AmenidadesPorInmueble>(entity =>
            {
                entity.HasKey(e => e.IdAmenidadesPorInmueble);

                entity.ToTable("AmenidadesPorInmueble");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdAmenidadNavigation)
                    .WithMany(p => p.AmenidadesPorInmuebles)
                    .HasForeignKey(d => d.IdAmenidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Amenidade__IdAme__5629CD9C");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.AmenidadesPorInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Amenidade__IdInm__571DF1D5");
            });

            modelBuilder.Entity<CalificacionReservacione>(entity =>
            {
                entity.HasKey(e => e.IdCalificacionReserva)
                    .HasName("PK__Califica__7460F5B5B74F488D");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.PromedioCalificacion).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.IdReservacionNavigation)
                    .WithMany(p => p.CalificacionReservaciones)
                    .HasForeignKey(d => d.IdReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calificac__IdRes__73BA3083");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.CalificacionReservaciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calificac__IdUsu__74AE54BC");
            });

            modelBuilder.Entity<CalificacionUsuario>(entity =>
            {
                entity.HasKey(e => e.IdCalificacionUsuario)
                    .HasName("PK__Califica__0B93370B9CB8F026");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.PromedioCalificacion).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.IdUsuarioCalificadoNavigation)
                    .WithMany(p => p.CalificacionUsuarioIdUsuarioCalificadoNavigations)
                    .HasForeignKey(d => d.IdUsuarioCalificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calificac__IdUsu__778AC167");

                entity.HasOne(d => d.IdUsuarioCalificadorNavigation)
                    .WithMany(p => p.CalificacionUsuarioIdUsuarioCalificadorNavigations)
                    .HasForeignKey(d => d.IdUsuarioCalificador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calificac__IdUsu__787EE5A0");
            });

            modelBuilder.Entity<CaracteristicasInmueble>(entity =>
            {
                entity.HasKey(e => e.IdCaracteristica)
                    .HasName("PK__Caracter__8761175CFFC26C5C");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.CaracteristicasInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Caracteri__IdInm__4AB81AF0");
            });

            modelBuilder.Entity<CuentasBancaria>(entity =>
            {
                entity.HasKey(e => e.IdCuentaBancaria)
                    .HasName("PK__CuentasB__98C58F754B10E531");

                entity.HasIndex(e => e.NumeroCuenta, "UQ__CuentasB__E039507BEEC79541")
                    .IsUnique();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoDisponible).HasColumnType("money");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.CuentasBancaria)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CuentasBa__IdUsu__06CD04F7");
            });

            modelBuilder.Entity<Denuncia>(entity =>
            {
                entity.HasKey(e => e.IdDenuncia)
                    .HasName("PK__Denuncia__73AFA6C39F588511");

                entity.Property(e => e.Denuncia1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Denuncia");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Solucion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdReservacionNavigation)
                    .WithMany(p => p.Denuncia)
                    .HasForeignKey(d => d.IdReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Denuncias__IdRes__7D439ABD");

                entity.HasOne(d => d.IdStatusDenunciaNavigation)
                    .WithMany(p => p.Denuncia)
                    .HasForeignKey(d => d.IdStatusDenuncia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Denuncias__IdSta__7F2BE32F");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Denuncia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Denuncias__IdUsu__7E37BEF6");
            });

            modelBuilder.Entity<DisponibilidadInmueble>(entity =>
            {
                entity.HasKey(e => e.IdDisponibilidad)
                    .HasName("PK__Disponib__AE82DB17A0E21001");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.DisponibilidadInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Disponibi__IdInm__4D94879B");
            });

            modelBuilder.Entity<Favorito>(entity =>
            {
                entity.HasKey(e => e.IdFavorito)
                    .HasName("PK__Favorito__39DCEE50B54CDA75");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.Favoritos)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Favoritos__IdInm__412EB0B6");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Favoritos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Favoritos__IdUsu__4222D4EF");
            });

            modelBuilder.Entity<HistoricoLugaresVisitado>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoLugarVisitado)
                    .HasName("PK__Historic__6EA8C6EF021D71A4");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdReservacionNavigation)
                    .WithMany(p => p.HistoricoLugaresVisitados)
                    .HasForeignKey(d => d.IdReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Historico__IdRes__6FE99F9F");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.HistoricoLugaresVisitados)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Historico__IdUsu__70DDC3D8");
            });

            modelBuilder.Entity<ImagenesInmueble>(entity =>
            {
                entity.HasKey(e => e.IdImagen)
                    .HasName("PK__Imagenes__B42D8F2AC6CFFB90");

                entity.ToTable("ImagenesInmueble");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.ImagenesInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImagenesI__IdInm__44FF419A");
            });

            modelBuilder.Entity<Inmueble>(entity =>
            {
                entity.HasKey(e => e.IdInmueble)
                    .HasName("PK__Inmueble__6B8E7D3EA0B8D785");

                entity.Property(e => e.DescripcionInmuebles)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.PrecioPorNoche).HasColumnType("money");

                entity.Property(e => e.PromedioCalificacion).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TituloInmueble)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoInmuebleNavigation)
                    .WithMany(p => p.Inmuebles)
                    .HasForeignKey(d => d.IdTipoInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inmuebles__IdTip__3E52440B");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Inmuebles)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inmuebles__IdUsu__3D5E1FD2");
            });

            modelBuilder.Entity<Politica>(entity =>
            {
                entity.HasKey(e => e.IdPolitica)
                    .HasName("PK__Politica__B7DF5F4601F4B7AF");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<PoliticasPorInmueble>(entity =>
            {
                entity.HasKey(e => e.IdPoliticasPorInmueble);

                entity.ToTable("PoliticasPorInmueble");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.PoliticasPorInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Politicas__IdInm__5BE2A6F2");

                entity.HasOne(d => d.IdPoliticaNavigation)
                    .WithMany(p => p.PoliticasPorInmuebles)
                    .HasForeignKey(d => d.IdPolitica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Politicas__IdPol__5AEE82B9");
            });

            modelBuilder.Entity<ReservacionCheckIn>(entity =>
            {
                entity.HasKey(e => e.IdReservacionCheckIn)
                    .HasName("PK__Reservac__5611C99BCE88CB34");

                entity.ToTable("ReservacionCheckIn");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdReservacionNavigation)
                    .WithMany(p => p.ReservacionCheckIns)
                    .HasForeignKey(d => d.IdReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservaci__IdRes__6A30C649");
            });

            modelBuilder.Entity<ReservacionCheckOut>(entity =>
            {
                entity.HasKey(e => e.IdReservacionCheckIn)
                    .HasName("PK__Reservac__5611C99BA9F9D222");

                entity.ToTable("ReservacionCheckOut");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdReservacionNavigation)
                    .WithMany(p => p.ReservacionCheckOuts)
                    .HasForeignKey(d => d.IdReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservaci__IdRes__6D0D32F4");
            });

            modelBuilder.Entity<Reservacione>(entity =>
            {
                entity.HasKey(e => e.IdReservacion)
                    .HasName("PK__Reservac__52824637274754BF");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaSalida).HasColumnType("date");

                entity.Property(e => e.MontoDescuento).HasColumnType("money");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservaci__IdInm__656C112C");

                entity.HasOne(d => d.IdStatusReservacionNavigation)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.IdStatusReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservaci__IdSta__6754599E");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservaci__IdUsu__66603565");
            });

            modelBuilder.Entity<Restriccione>(entity =>
            {
                entity.HasKey(e => e.IdRestriccion)
                    .HasName("PK__Restricc__B237C62CAECD16A7");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<RestriccionesPorInmueble>(entity =>
            {
                entity.HasKey(e => e.IdRestriccionesPorInmueble);

                entity.ToTable("RestriccionesPorInmueble");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.RestriccionesPorInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restricci__IdInm__60A75C0F");

                entity.HasOne(d => d.IdRestriccionNavigation)
                    .WithMany(p => p.RestriccionesPorInmuebles)
                    .HasForeignKey(d => d.IdRestriccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restricci__IdRes__5FB337D6");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__2DCCF9A2B0CEAE72");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiciosPorInmueble>(entity =>
            {
                entity.HasKey(e => e.IdServiciosPorInmueble);

                entity.ToTable("ServiciosPorInmueble");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdInmueblesNavigation)
                    .WithMany(p => p.ServiciosPorInmuebles)
                    .HasForeignKey(d => d.IdInmuebles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Servicios__IdInm__52593CB8");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.ServiciosPorInmuebles)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Servicios__IdSer__5165187F");
            });

            modelBuilder.Entity<StatusDenuncium>(entity =>
            {
                entity.HasKey(e => e.IdStatusDenuncia)
                    .HasName("PK__StatusDe__A3642D0839FC8A5F");

                entity.Property(e => e.StatusDenuncia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusReservacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusReservacion)
                    .HasName("PK__StatusRe__15837A451C11F0E9");

                entity.ToTable("StatusReservacion");

                entity.Property(e => e.StatusReservacion1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("StatusReservacion");
            });

            modelBuilder.Entity<TipoInmueble>(entity =>
            {
                entity.HasKey(e => e.IdTipoInmueble)
                    .HasName("PK__TipoInmu__B21A651553FA0F38");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.TipoInmueble1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TipoInmueble");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__CA04062BC39CF41B");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.TipoUsuario1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TipoUsuario");
            });

            modelBuilder.Entity<TiposTransaccion>(entity =>
            {
                entity.HasKey(e => e.IdTipoTransaccion)
                    .HasName("PK__TiposTra__FE769C8D1DE81D6D");

                entity.ToTable("TiposTransaccion");

                entity.Property(e => e.TipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.HasKey(e => e.IdTransaccion)
                    .HasName("PK__Transacc__334B1F7747A8513D");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTransaccion).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.TransaccioneIdCuentaBancariaNavigations)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacci__IdCue__0C85DE4D");

                entity.HasOne(d => d.IdCuentaBancariaDestinoNavigation)
                    .WithMany(p => p.TransaccioneIdCuentaBancariaDestinoNavigations)
                    .HasForeignKey(d => d.IdCuentaBancariaDestino)
                    .HasConstraintName("FK__Transacci__IdCue__0E6E26BF");

                entity.HasOne(d => d.IdCuentaBancariaOrigenNavigation)
                    .WithMany(p => p.TransaccioneIdCuentaBancariaOrigenNavigations)
                    .HasForeignKey(d => d.IdCuentaBancariaOrigen)
                    .HasConstraintName("FK__Transacci__IdCue__0D7A0286");

                entity.HasOne(d => d.IdTipoTransaccionNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.IdTipoTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacci__IdTip__0B91BA14");
            });

            modelBuilder.Entity<UbicacionInmueble>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion)
                    .HasName("PK__Ubicacio__778CAB1DF1A058A5");

                entity.Property(e => e.Canton)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Distrito)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionDetalles)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInmuebleNavigation)
                    .WithMany(p => p.UbicacionInmuebles)
                    .HasForeignKey(d => d.IdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ubicacion__IdInm__47DBAE45");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF97206CCA33");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.FotoIdentificacion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTelefono)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromedioCalificacion).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdTipo__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
