using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppRazor.DAIF2020
{
    public partial class DAIF2020Context : DbContext
    {
        public DAIF2020Context()
        {
        }

        public DAIF2020Context(DbContextOptions<DAIF2020Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityStatus> ActivityStatus { get; set; }
        public virtual DbSet<ArchivedGame> ArchivedGame { get; set; }
        public virtual DbSet<Arena> Arena { get; set; }
        public virtual DbSet<ArenaStatus> ArenaStatus { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<ClubStatus> ClubStatus { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Game20192020> Game20192020 { get; set; }
        public virtual DbSet<GameCategory> GameCategory { get; set; }
        public virtual DbSet<GameStatus> GameStatus { get; set; }
        public virtual DbSet<GameType> GameType { get; set; }
        public virtual DbSet<Hockey4LifeLog> Hockey4LifeLog { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Meeting> Meeting { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonRole> PersonRole { get; set; }
        public virtual DbSet<PersonStatus> PersonStatus { get; set; }
        public virtual DbSet<PersonType> PersonType { get; set; }
        public virtual DbSet<PoolGame> PoolGame { get; set; }
        public virtual DbSet<PoolGameReceipt> PoolGameReceipt { get; set; }
        public virtual DbSet<Pzgame> Pzgame { get; set; }
        public virtual DbSet<PzgameReceipt> PzgameReceipt { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReceiptCategory> ReceiptCategory { get; set; }
        public virtual DbSet<ReceiptStatus> ReceiptStatus { get; set; }
        public virtual DbSet<ReceiptType> ReceiptType { get; set; }
        public virtual DbSet<RefFees> RefFees { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesStatus> SeriesStatus { get; set; }
        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<SportsLog> SportsLog { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamRoster> TeamRoster { get; set; }
        public virtual DbSet<TeamStatus> TeamStatus { get; set; }
        public virtual DbSet<Tornament> Tornament { get; set; }
        public virtual DbSet<TournamentType> TournamentType { get; set; }
        public virtual DbSet<Tsmgame> Tsmgame { get; set; }
        public virtual DbSet<TsmgameStatus> TsmgameStatus { get; set; }
        public virtual DbSet<WeeklyReciept> WeeklyReciept { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
        public virtual DbSet<ZoneGame> ZoneGame { get; set; }
        public virtual DbSet<ZoneGameReceipt> ZoneGameReceipt { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-QK56LK9\\MSSQLDEVELOPMENT;Trusted_Connection=true; Database=DAIF2020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ActivityStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ArchivedGame>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hd1).HasColumnName("HD1");

                entity.Property(e => e.Hd2).HasColumnName("HD2");

                entity.Property(e => e.Ld1).HasColumnName("LD1");

                entity.Property(e => e.Ld2).HasColumnName("LD2");

                entity.Property(e => e.ParticipatedTime).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Arena>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ArenaStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ClubStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tsmnumber).HasColumnName("TSMNumber");
            });

            modelBuilder.Entity<Game20192020>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hd1).HasColumnName("HD1");

                entity.Property(e => e.Hd2).HasColumnName("HD2");

                entity.Property(e => e.Ld1).HasColumnName("LD1");

                entity.Property(e => e.Ld2).HasColumnName("LD2");

                entity.Property(e => e.TsmgameStatusId).HasColumnName("TSMGameStatusId");
            });

            modelBuilder.Entity<GameCategory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<GameStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Hockey4LifeLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PersonRole>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PersonStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PersonType>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PoolGame>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PoolGameReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmountPaidUdz1).HasColumnName("AmountPaidUDZ1");

                entity.Property(e => e.AmountPaidUdz2).HasColumnName("AmountPaidUDZ2");

                entity.Property(e => e.Duz1lateGameKost).HasColumnName("DUZ1LateGameKost");

                entity.Property(e => e.Udz1alowens).HasColumnName("UDZ1Alowens");

                entity.Property(e => e.Udz1fee).HasColumnName("UDZ1Fee");

                entity.Property(e => e.Udz1other).HasColumnName("UDZ1Other");

                entity.Property(e => e.Udz1totalFee).HasColumnName("UDZ1TotalFee");

                entity.Property(e => e.Udz1travelKost).HasColumnName("UDZ1TravelKost");

                entity.Property(e => e.Udz2alowens).HasColumnName("UDZ2Alowens");

                entity.Property(e => e.Udz2fee).HasColumnName("UDZ2Fee");

                entity.Property(e => e.Udz2lateGameKost).HasColumnName("UDZ2LateGameKost");

                entity.Property(e => e.Udz2other).HasColumnName("UDZ2Other");

                entity.Property(e => e.Udz2totalFee).HasColumnName("UDZ2TotalFee");

                entity.Property(e => e.Udz2travelKost).HasColumnName("UDZ2TravelKost");
            });

            modelBuilder.Entity<Pzgame>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PZGame");

                entity.Property(e => e.PzgameName).HasColumnName("PZGameName");
            });

            modelBuilder.Entity<PzgameReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PZGameReceipt");

                entity.Property(e => e.PzgameId).HasColumnName("PZGameId");

                entity.Property(e => e.Udz1fee).HasColumnName("UDZ1Fee");

                entity.Property(e => e.Udz2fee).HasColumnName("UDZ2Fee");

                entity.Property(e => e.Udz3fee).HasColumnName("UDZ3Fee");

                entity.Property(e => e.Udz4fee).HasColumnName("UDZ4Fee");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmountPaidHd1).HasColumnName("AmountPaidHD1");

                entity.Property(e => e.AmountPaidHd2).HasColumnName("AmountPaidHD2");

                entity.Property(e => e.AmountPaidLd1).HasColumnName("AmountPaidLD1");

                entity.Property(e => e.AmountPaidLd2).HasColumnName("AmountPaidLD2");

                entity.Property(e => e.Hd1alowens).HasColumnName("HD1Alowens");

                entity.Property(e => e.Hd1fee).HasColumnName("HD1Fee");

                entity.Property(e => e.Hd1lateGameKost).HasColumnName("HD1LateGameKost");

                entity.Property(e => e.Hd1other).HasColumnName("HD1Other");

                entity.Property(e => e.Hd1totalFee).HasColumnName("HD1TotalFee");

                entity.Property(e => e.Hd1travelKost).HasColumnName("HD1TravelKost");

                entity.Property(e => e.Hd2alowens).HasColumnName("HD2Alowens");

                entity.Property(e => e.Hd2fee).HasColumnName("HD2Fee");

                entity.Property(e => e.Hd2lateGameKost).HasColumnName("HD2LateGameKost");

                entity.Property(e => e.Hd2other).HasColumnName("HD2Other");

                entity.Property(e => e.Hd2totalFee).HasColumnName("HD2TotalFee");

                entity.Property(e => e.Hd2travelKost).HasColumnName("HD2TravelKost");

                entity.Property(e => e.Ld1alowens).HasColumnName("LD1Alowens");

                entity.Property(e => e.Ld1fee).HasColumnName("LD1Fee");

                entity.Property(e => e.Ld1lateGameKost).HasColumnName("LD1LateGameKost");

                entity.Property(e => e.Ld1other).HasColumnName("LD1Other");

                entity.Property(e => e.Ld1totalFee).HasColumnName("LD1TotalFee");

                entity.Property(e => e.Ld1travelKost).HasColumnName("LD1TravelKost");

                entity.Property(e => e.Ld2alowens).HasColumnName("LD2Alowens");

                entity.Property(e => e.Ld2fee).HasColumnName("LD2Fee");

                entity.Property(e => e.Ld2lateGameKost).HasColumnName("LD2LateGameKost");

                entity.Property(e => e.Ld2other).HasColumnName("LD2Other");

                entity.Property(e => e.Ld2totalFee).HasColumnName("LD2TotalFee");

                entity.Property(e => e.Ld2travelKost).HasColumnName("LD2TravelKost");
            });

            modelBuilder.Entity<ReceiptCategory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ReceiptStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ReceiptType>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<RefFees>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hd).HasColumnName("HD");

                entity.Property(e => e.Ld).HasColumnName("LD");

                entity.Property(e => e.Udz).HasColumnName("UDZ");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SeriesStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SportsLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TimeSpent).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TeamRoster>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TeamStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tornament>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TournamentType>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tsmgame>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TSMGame");

                entity.Property(e => e.Hd1).HasColumnName("HD1");

                entity.Property(e => e.Hd2).HasColumnName("HD2");

                entity.Property(e => e.Ld1).HasColumnName("LD1");

                entity.Property(e => e.Ld2).HasColumnName("LD2");

                entity.Property(e => e.TsmgameStatusId).HasColumnName("TSMGameStatusId");
            });

            modelBuilder.Entity<TsmgameStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TSMGameStatus");

                entity.Property(e => e.TsmgameStatusName).HasColumnName("TSMGameStatusName");
            });

            modelBuilder.Entity<WeeklyReciept>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ZoneGame>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TsmnumberZone1).HasColumnName("TSMNumberZone1");

                entity.Property(e => e.TsmnumberZone2).HasColumnName("TSMNumberZone2");
            });

            modelBuilder.Entity<ZoneGameReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmountPaidUdz1).HasColumnName("AmountPaidUDZ1");

                entity.Property(e => e.AmountPaidUdz2).HasColumnName("AmountPaidUDZ2");

                entity.Property(e => e.Udz1alowens).HasColumnName("UDZ1Alowens");

                entity.Property(e => e.Udz1fee).HasColumnName("UDZ1Fee");

                entity.Property(e => e.Udz1lateGameKost).HasColumnName("UDZ1LateGameKost");

                entity.Property(e => e.Udz1other).HasColumnName("UDZ1Other");

                entity.Property(e => e.Udz1totalFee).HasColumnName("UDZ1TotalFee");

                entity.Property(e => e.Udz1travelKost).HasColumnName("UDZ1TravelKost");

                entity.Property(e => e.Udz2alowens).HasColumnName("UDZ2Alowens");

                entity.Property(e => e.Udz2fee).HasColumnName("UDZ2Fee");

                entity.Property(e => e.Udz2lateGameKost).HasColumnName("UDZ2LateGameKost");

                entity.Property(e => e.Udz2other).HasColumnName("UDZ2Other");

                entity.Property(e => e.Udz2totalFee).HasColumnName("UDZ2TotalFee");

                entity.Property(e => e.Udz2travelKost).HasColumnName("UDZ2TravelKost");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
