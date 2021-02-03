using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppRazor.Models
{
    public partial class DAIF2021Context : DbContext
    {
        public DAIF2021Context()
        {
        }

        public DAIF2021Context(DbContextOptions<DAIF2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Arena> Arena { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<DastTest> DastTest { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<Workout> Workout { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QK56LK9\\MSSQLDEVELOPMENT;Trusted_Connection=true; Database=DAIF2021");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<DastTest>(entity =>
            {
                entity.HasIndex(e => e.ArenaId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.SportId);

                entity.Property(e => e.TimeSet1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeSet2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeSet3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeSet4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Arena)
                    .WithMany(p => p.DastTest)
                    .HasForeignKey(d => d.ArenaId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.DastTest)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.DastTest)
                    .HasForeignKey(d => d.SportId);
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.HasIndex(e => e.ArenaId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.SportId);

                entity.Property(e => e.Distance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kcal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Arena)
                    .WithMany(p => p.Workout)
                    .HasForeignKey(d => d.ArenaId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Workout)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.Workout)
                    .HasForeignKey(d => d.SportId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
