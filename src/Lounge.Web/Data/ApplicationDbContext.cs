﻿using Lounge.Web.Data.Entities;
using Lounge.Web.Data.Entities.ChangeTracking;
using Lounge.Web.Settings;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lounge.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ILoungeSettingsService loungeSettingsService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoungeSettingsService loungeSettingsOptions)
            : base(options)
        {
            this.loungeSettingsService = loungeSettingsOptions;
        }

        public DbSet<Player> Players => Set<Player>();
        public DbSet<PlayerSeasonData> PlayerSeasonData => Set<PlayerSeasonData>();
        public DbSet<Table> Tables => Set<Table>();
        public DbSet<TableScore> TableScores => Set<TableScore>();
        public DbSet<Penalty> Penalties => Set<Penalty>();
        public DbSet<Bonus> Bonuses => Set<Bonus>();
        public DbSet<Placement> Placements => Set<Placement>();
        public DbSet<NameChange> NameChanges => Set<NameChange>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var defaultSeason = loungeSettingsService.CurrentSeason;

            modelBuilder.Entity<Player>().ToTable("Players");
            modelBuilder.Entity<PlayerSeasonData>().ToTable("PlayerSeasonData");
            modelBuilder.Entity<Table>().ToTable("Tables");
            modelBuilder.Entity<TableScore>().ToTable("TableScores");
            modelBuilder.Entity<Penalty>().ToTable("Penalties");
            modelBuilder.Entity<Bonus>().ToTable("Bonuses");
            modelBuilder.Entity<Placement>().ToTable("Placements");
            modelBuilder.Entity<NameChange>().ToTable("NameChanges");

            modelBuilder.Entity<Player>()
                .HasIndex(p => p.MKCId)
                .IsUnique();

            modelBuilder.Entity<Player>()
                .HasIndex(p => p.DiscordId)
                .IsUnique();

            modelBuilder.Entity<Player>()
                .HasIndex(p => p.NormalizedName)
                .IsUnique();

            modelBuilder.Entity<PlayerChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => x.Id);

            modelBuilder.Entity<PlayerSeasonData>()
                .Property(psd => psd.Season)
                .HasDefaultValue(defaultSeason);

            modelBuilder.Entity<PlayerSeasonData>()
                .HasKey(psd => new { psd.PlayerId, psd.Season });

            modelBuilder.Entity<PlayerSeasonData>()
                .HasIndex(psd => new { psd.Season, psd.Mmr });

            modelBuilder.Entity<PlayerSeasonDataChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => new { x.PlayerId, x.Season });

            modelBuilder.Entity<Table>()
                .Property(t => t.Season)
                .HasDefaultValue(defaultSeason);

            modelBuilder.Entity<TableChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => x.Id);

            modelBuilder.Entity<TableScore>()
                .HasKey(t => new { t.TableId, t.PlayerId });

            modelBuilder.Entity<TableScoreChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => new { x.TableId, x.PlayerId });

            modelBuilder.Entity<Penalty>()
                .HasIndex(p => p.AwardedOn);

            modelBuilder.Entity<Penalty>()
                .Property(p => p.Season)
                .HasDefaultValue(defaultSeason);

            modelBuilder.Entity<PenaltyChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => x.Id);

            modelBuilder.Entity<Bonus>()
                .HasIndex(p => p.AwardedOn);

            modelBuilder.Entity<Bonus>()
                .Property(b => b.Season)
                .HasDefaultValue(defaultSeason);

            modelBuilder.Entity<BonusChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => x.Id);

            modelBuilder.Entity<Placement>()
                .HasIndex(p => p.AwardedOn);

            modelBuilder.Entity<Placement>()
                .Property(p => p.Season)
                .HasDefaultValue(defaultSeason);

            modelBuilder.Entity<PlacementChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => x.Id);

            modelBuilder.Entity<NameChange>()
                .HasIndex(nc => nc.ChangedOn);

            modelBuilder.Entity<NameChange>()
                .Property(nc => nc.Season)
                .HasDefaultValue(defaultSeason);

            modelBuilder.Entity<NameChangeChange>()
                .HasOne(x => x.Entity).WithMany().HasForeignKey(x => x.Id);

            modelBuilder.Entity<ChangeTrackingCurrentVersion>()
                .HasNoKey()
                .ToView(null);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime))
                    {
                        modelBuilder.Entity(entityType.ClrType)
                         .Property<DateTime>(property.Name)
                         .HasConversion(
                          v => v.ToUniversalTime(),
                          v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
                    }
                    else if (property.ClrType == typeof(DateTime?))
                    {
                        modelBuilder.Entity(entityType.ClrType)
                         .Property<DateTime?>(property.Name)
                         .HasConversion(
                          v => v.HasValue ? v.Value.ToUniversalTime() : v,
                          v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v);
                    }
                }
            }

            foreach (var changeType in modelBuilder.Model.FindLeastDerivedEntityTypes(typeof(Change)))
            {
                var builder = modelBuilder.Entity(changeType.ClrType).HasNoKey().ToView(null);

                builder.Property(nameof(Change.Version)).HasColumnName("SYS_CHANGE_VERSION");
                builder.Property(nameof(Change.CreationVersion)).HasColumnName("SYS_CHANGE_CREATION_VERSION");
                builder.Property(nameof(Change.Operation)).HasColumnName("SYS_CHANGE_OPERATION");
                builder.Property(nameof(Change.Columns)).HasColumnName("SYS_CHANGE_COLUMNS");
                builder.Property(nameof(Change.Context)).HasColumnName("SYS_CHANGE_CONTEXT");
            }
        }
    }
}
