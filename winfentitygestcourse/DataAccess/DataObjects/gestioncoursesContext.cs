using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class gestioncoursesContext : DbContext
    {
        public gestioncoursesContext()
        {
        }

        public gestioncoursesContext(DbContextOptions<gestioncoursesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arrivee> Arrivee { get; set; }
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Coureur> Coureur { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Inscription> Inscription { get; set; }
        public virtual DbSet<Transpondeur> Transpondeur { get; set; }
        public virtual DbSet<VCoureur> VCoureur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=gestioncourses");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arrivee>(entity =>
            {
                entity.HasKey(e => e.IdArrivee)
                    .HasName("PRIMARY");

                entity.ToTable("arrivee");

                entity.HasIndex(e => e.InscriptionIdInscription)
                    .HasName("arrivee_inscription");

                entity.Property(e => e.IdArrivee).HasColumnType("int(11)");

                entity.Property(e => e.InscriptionIdInscription)
                    .HasColumnName("Inscription_IdInscription")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.InscriptionIdInscriptionNavigation)
                    .WithMany(p => p.Arrivee)
                    .HasForeignKey(d => d.InscriptionIdInscription)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arrivee_inscription");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie)
                    .HasName("PRIMARY");

                entity.ToTable("categorie");

                entity.Property(e => e.IdCategorie).HasColumnType("int(11)");

                entity.Property(e => e.AgeMaxi).HasColumnType("int(11)");

                entity.Property(e => e.AgeMini).HasColumnType("int(11)");

                entity.Property(e => e.DistanceMax).HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasKey(e => e.IdClub)
                    .HasName("PRIMARY");

                entity.ToTable("club");

                entity.Property(e => e.IdClub).HasColumnType("int(11)");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CodePostal)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Coureur>(entity =>
            {
                entity.HasKey(e => e.IdCoureur)
                    .HasName("PRIMARY");

                entity.ToTable("coureur");

                entity.HasIndex(e => e.CategorieIdCategorie)
                    .HasName("Categorie_IdCategorie");

                entity.HasIndex(e => e.ClubIdClub)
                    .HasName("Club_Coureur");

                entity.Property(e => e.IdCoureur).HasColumnType("int(11)");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CategorieIdCategorie)
                    .HasColumnName("Categorie_IdCategorie")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClubIdClub)
                    .HasColumnName("Club_IdClub")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodePostal).HasColumnType("int(11)");

                entity.Property(e => e.DateNaissance).HasColumnType("date");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Sexe)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.HasOne(d => d.CategorieIdCategorieNavigation)
                    .WithMany(p => p.Coureur)
                    .HasForeignKey(d => d.CategorieIdCategorie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Categorie_coureur");

                entity.HasOne(d => d.ClubIdClubNavigation)
                    .WithMany(p => p.Coureur)
                    .HasForeignKey(d => d.ClubIdClub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Club_Coureur");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.IdCourse)
                    .HasName("PRIMARY");

                entity.ToTable("course");

                entity.Property(e => e.IdCourse).HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Distance).HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => e.IdInscription)
                    .HasName("PRIMARY");

                entity.ToTable("inscription");

                entity.HasIndex(e => e.CoureurIdCoureur)
                    .HasName("coureur_IdCoureur");

                entity.HasIndex(e => e.CourseIdCourse)
                    .HasName("course_IdCourse");

                entity.HasIndex(e => e.TranspondeurIdTranspondeur)
                    .HasName("transpondeur_IdTranspondeur");

                entity.Property(e => e.IdInscription).HasColumnType("int(11)");

                entity.Property(e => e.CoureurIdCoureur)
                    .HasColumnName("coureur_IdCoureur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseIdCourse)
                    .HasColumnName("course_IdCourse")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumDossard).HasColumnType("int(11)");

                entity.Property(e => e.TranspondeurIdTranspondeur)
                    .HasColumnName("transpondeur_IdTranspondeur")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CoureurIdCoureurNavigation)
                    .WithMany(p => p.Inscription)
                    .HasForeignKey(d => d.CoureurIdCoureur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Coureur_Inscription");

                entity.HasOne(d => d.CourseIdCourseNavigation)
                    .WithMany(p => p.Inscription)
                    .HasForeignKey(d => d.CourseIdCourse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Course_Inscription");

                entity.HasOne(d => d.TranspondeurIdTranspondeurNavigation)
                    .WithMany(p => p.Inscription)
                    .HasForeignKey(d => d.TranspondeurIdTranspondeur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Transpondeur_Inscription");
            });

            modelBuilder.Entity<Transpondeur>(entity =>
            {
                entity.HasKey(e => e.IdTranspondeur)
                    .HasName("PRIMARY");

                entity.ToTable("transpondeur");

                entity.Property(e => e.IdTranspondeur).HasColumnType("int(11)");
            });

            modelBuilder.Entity<VCoureur>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_coureur");

                entity.Property(e => e.VNom)
                    .IsRequired()
                    .HasColumnName("V_NOM")
                    .HasMaxLength(45);

                entity.Property(e => e.VPrenom)
                    .IsRequired()
                    .HasColumnName("V_PRENOM")
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
