namespace O7ECM.Code
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ECMEntities : DbContext
    {
        public ECMEntities()
            : base("name=ECMEntities")
        {
        }

        public virtual DbSet<Acceso> Accesos { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Bandeja> Bandejas { get; set; }
        public virtual DbSet<Entidad> Entidades { get; set; }
        public virtual DbSet<MaestroRepositorio> MaestroRepositorios { get; set; }
        public virtual DbSet<Regla> Reglas { get; set; }
        public virtual DbSet<Tramite> Tramites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceso>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Acceso>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Acceso>()
                .Property(e => e.CodigoUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Acceso>()
                .Property(e => e.NivelAcceso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Actividades>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Actividades>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Actividades>()
                .Property(e => e.DescripcionActividad)
                .IsUnicode(false);

            modelBuilder.Entity<Actividades>()
                .HasMany(e => e.Regla)
                .WithRequired(e => e.Actividades)
                .HasForeignKey(e => new { e.CodigoCompania, e.CodigoSucursal, e.CodigoActividad })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bandeja>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bandeja>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bandeja>()
                .Property(e => e.NombreBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<Bandeja>()
                .HasMany(e => e.Acceso)
                .WithRequired(e => e.Bandeja)
                .HasForeignKey(e => new { e.CodigoCompania, e.CodigoSucursal, e.Codigobandeja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bandeja>()
                .HasMany(e => e.Regla)
                .WithRequired(e => e.Bandeja)
                .HasForeignKey(e => new { e.CodigoCompania, e.CodigoSucursal, e.CodigoBandeja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.NombreEntidad)
                .IsUnicode(false);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.TipoEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.CorreoEntidad)
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.NombreRepositorio)
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.NombreEtiqueta)
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.NumeroTelofono)
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .Property(e => e.NumeroAnexo)
                .IsUnicode(false);

            modelBuilder.Entity<MaestroRepositorio>()
                .HasMany(e => e.Acceso)
                .WithRequired(e => e.MestroRepositorio)
                .HasForeignKey(e => new { e.CodigoCompania, e.CodigoSucursal, e.Codigorepositorio })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regla>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Regla>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tramite>()
                .Property(e => e.CodigoCompania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tramite>()
                .Property(e => e.CodigoSucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tramite>()
                .Property(e => e.DescripcionTramite)
                .IsUnicode(false);

            modelBuilder.Entity<Tramite>()
                .HasMany(e => e.Regla)
                .WithRequired(e => e.Tramite)
                .HasForeignKey(e => new { e.CodigoCompania, e.CodigoSucursal, e.CodigoTramite })
                .WillCascadeOnDelete(false);
        }
    }
}
