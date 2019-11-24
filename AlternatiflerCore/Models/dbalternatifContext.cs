using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AlternatiflerCore.Models
{
    public partial class dbalternatifContext : DbContext
    {
        public dbalternatifContext()
        {
        }

        public dbalternatifContext(DbContextOptions<dbalternatifContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblalternatifler> Tblalternatifler { get; set; }
        public virtual DbSet<Tblgeciciurunbilgisi> Tblgeciciurunbilgisi { get; set; }
        public virtual DbSet<Tblkategoriler> Tblkategoriler { get; set; }
        public virtual DbSet<Tblresimler> Tblresimler { get; set; }
        public virtual DbSet<Tblsistem> Tblsistem { get; set; }
        public virtual DbSet<Tblsubkategori> Tblsubkategori { get; set; }
        public virtual DbSet<Tblsubsistem> Tblsubsistem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=dbalternatif;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tblalternatifler>(entity =>
            {
                entity.ToTable("tblalternatifler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SiteUuid)
                    .HasColumnName("siteUUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblgeciciurunbilgisi>(entity =>
            {
                entity.ToTable("tblgeciciurunbilgisi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Etiketler)
                    .HasColumnName("etiketler")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Islemdurumu)
                    .HasColumnName("islemdurumu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteUuid)
                    .HasColumnName("siteUUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uretici)
                    .HasColumnName("uretici")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Urlad)
                    .HasColumnName("urlad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Urunurl)
                    .HasColumnName("urunurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblkategoriler>(entity =>
            {
                entity.ToTable("tblkategoriler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblresimler>(entity =>
            {
                entity.ToTable("tblresimler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Indirilmedurumu)
                    .HasColumnName("indirilmedurumu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Resimtur)
                    .HasColumnName("resimtur")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Resimurl)
                    .HasColumnName("resimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UrunUuid)
                    .HasColumnName("urunUUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblsistem>(entity =>
            {
                entity.ToTable("tblsistem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblsubkategori>(entity =>
            {
                entity.ToTable("tblsubkategori");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentid).HasColumnName("parentid");
            });

            modelBuilder.Entity<Tblsubsistem>(entity =>
            {
                entity.ToTable("tblsubsistem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Urunadedi).HasColumnName("urunadedi");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
