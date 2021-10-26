using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsentitycore.DataAcess.dataObjects
{
    public partial class formationsContext : DbContext
    {
        public formationsContext()
        {
        }

        public formationsContext(DbContextOptions<formationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Formation> Formation { get; set; }
        public virtual DbSet<Stagiaire> Stagiaire { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=formations");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>(entity =>
            {
                entity.HasKey(e => e.IdFormation)
                    .HasName("PRIMARY");

                entity.ToTable("formation");

                entity.Property(e => e.IdFormation)
                    .HasColumnName("idFormation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NbStagiaire)
                    .HasColumnName("nbStagiaire")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Niveau)
                    .IsRequired()
                    .HasColumnName("niveau")
                    .HasMaxLength(45);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Stagiaire>(entity =>
            {
                entity.HasKey(e => e.IdStagiaire)
                    .HasName("PRIMARY");

                entity.ToTable("stagiaire");

                entity.HasIndex(e => e.IdFormation)
                    .HasName("idformation");

                entity.Property(e => e.IdStagiaire)
                    .HasColumnName("idStagiaire")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFormation)
                    .HasColumnName("idFormation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(45);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasColumnName("prenom")
                    .HasMaxLength(45);

                entity.HasOne(d => d.IdFormationNavigation)
                    .WithMany(p => p.Stagiaire)
                    .HasForeignKey(d => d.IdFormation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stagiaire_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
