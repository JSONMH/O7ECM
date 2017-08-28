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

        public virtual DbSet<ECMACCESO> ECMACCESOS { get; set; }
        public virtual DbSet<ECMACTIVID> ECMACTIVIDs { get; set; }
        public virtual DbSet<ECMBANDEJA> ECMBANDEJAs { get; set; }
        public virtual DbSet<ECMENTIDAD> ECMENTIDADs { get; set; }
        public virtual DbSet<ECMMAEREPO> ECMMAEREPOes { get; set; }
        public virtual DbSet<ECMREGLA> ECMREGLAS { get; set; }
        public virtual DbSet<ECMTRAMITE> ECMTRAMITEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ECMACCESO>()
                .Property(e => e.ACCCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMACCESO>()
                .Property(e => e.ACCCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMACCESO>()
                .Property(e => e.ACCCODUSR)
                .IsUnicode(false);

            modelBuilder.Entity<ECMACCESO>()
                .Property(e => e.ACCNIVACC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMACTIVID>()
                .Property(e => e.ACTCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMACTIVID>()
                .Property(e => e.ACTCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMACTIVID>()
                .Property(e => e.ACTDESACT)
                .IsUnicode(false);

            modelBuilder.Entity<ECMACTIVID>()
                .HasMany(e => e.ECMREGLAS)
                .WithRequired(e => e.ECMACTIVID)
                .HasForeignKey(e => new { e.REGCODCIA, e.REGCODSUC, e.REGCODACT })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECMBANDEJA>()
                .Property(e => e.BANCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMBANDEJA>()
                .Property(e => e.BANCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMBANDEJA>()
                .Property(e => e.BANNOMBAN)
                .IsUnicode(false);

            modelBuilder.Entity<ECMBANDEJA>()
                .HasMany(e => e.ECMACCESOS)
                .WithRequired(e => e.ECMBANDEJA)
                .HasForeignKey(e => new { e.ACCCODCIA, e.ACCCODSUC, e.ACCCODBAN })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECMBANDEJA>()
                .HasMany(e => e.ECMREGLAS)
                .WithRequired(e => e.ECMBANDEJA)
                .HasForeignKey(e => new { e.REGCODCIA, e.REGCODSUC, e.REGCODBAN })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECMENTIDAD>()
                .Property(e => e.ENTCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMENTIDAD>()
                .Property(e => e.ENTCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMENTIDAD>()
                .Property(e => e.ENTNOMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ECMENTIDAD>()
                .Property(e => e.ENTTIPENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMENTIDAD>()
                .Property(e => e.ENTMAILENT)
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPNOMREP)
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPNOMETI)
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPDIRREP)
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPTELREP)
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .Property(e => e.REPANEREP)
                .IsUnicode(false);

            modelBuilder.Entity<ECMMAEREPO>()
                .HasMany(e => e.ECMACCESOS)
                .WithRequired(e => e.ECMMAEREPO)
                .HasForeignKey(e => new { e.ACCCODCIA, e.ACCCODSUC, e.ACCCODREP })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECMREGLA>()
                .Property(e => e.REGCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMREGLA>()
                .Property(e => e.REGCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMTRAMITE>()
                .Property(e => e.TRACODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMTRAMITE>()
                .Property(e => e.TRACODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECMTRAMITE>()
                .Property(e => e.TRADESTRA)
                .IsUnicode(false);

            modelBuilder.Entity<ECMTRAMITE>()
                .HasMany(e => e.ECMREGLAS)
                .WithRequired(e => e.ECMTRAMITE)
                .HasForeignKey(e => new { e.REGCODCIA, e.REGCODSUC, e.REGCODTRA })
                .WillCascadeOnDelete(false);
        }
    }
}
