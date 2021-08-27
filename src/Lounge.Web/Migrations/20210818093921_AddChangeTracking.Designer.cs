﻿// <auto-generated />
using System;
using Lounge.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lounge.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210818093921_AddChangeTracking")]
    partial class AddChangeTracking
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lounge.Web.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AwardedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NewMmr")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PrevMmr")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(5);

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("Lounge.Web.Models.BonusChange", b =>
                {
                    b.Property<int>("BonusId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("BonusId");
                });

            modelBuilder.Entity("Lounge.Web.Models.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AwardedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsStrike")
                        .HasColumnType("bit");

                    b.Property<int>("NewMmr")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PrevMmr")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(5);

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("Lounge.Web.Models.PenaltyChange", b =>
                {
                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<int>("PenaltyId")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("PenaltyId");
                });

            modelBuilder.Entity("Lounge.Web.Models.Placement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AwardedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mmr")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("PrevMmr")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(5);

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Placements");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlacementChange", b =>
                {
                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<int>("PlacementId")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("PlacementId");
                });

            modelBuilder.Entity("Lounge.Web.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscordId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("bit");

                    b.Property<int>("MKCId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("RegistryId")
                        .HasColumnType("int");

                    b.Property<string>("SwitchFc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("DiscordId")
                        .IsUnique()
                        .HasFilter("[DiscordId] IS NOT NULL");

                    b.HasIndex("MKCId")
                        .IsUnique();

                    b.HasIndex("NormalizedName")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerChange", b =>
                {
                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("PlayerId");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerSeasonData", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(5);

                    b.Property<int?>("MaxMmr")
                        .HasColumnType("int");

                    b.Property<int>("Mmr")
                        .HasColumnType("int");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("PlayerId", "Season");

                    b.HasIndex("Season", "Mmr");

                    b.ToTable("PlayerSeasonData");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerSeasonDataChange", b =>
                {
                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("PlayerId", "Season");
                });

            modelBuilder.Entity("Lounge.Web.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumTeams")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(5);

                    b.Property<string>("TableMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableChange", b =>
                {
                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("TableId");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableScore", b =>
                {
                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<double>("Multiplier")
                        .HasColumnType("float");

                    b.Property<int?>("NewMmr")
                        .HasColumnType("int");

                    b.Property<int?>("PrevMmr")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.HasKey("TableId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("TableScores");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableScoreChange", b =>
                {
                    b.Property<byte[]>("Columns")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_COLUMNS");

                    b.Property<byte[]>("Context")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SYS_CHANGE_CONTEXT");

                    b.Property<long?>("CreationVersion")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_CREATION_VERSION");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("SYS_CHANGE_OPERATION");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint")
                        .HasColumnName("SYS_CHANGE_VERSION");

                    b.HasIndex("TableId", "PlayerId");
                });

            modelBuilder.Entity("Lounge.Web.Models.Bonus", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Bonuses")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.BonusChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.Bonus", "Entity")
                        .WithMany()
                        .HasForeignKey("BonusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.Penalty", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Penalties")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.PenaltyChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.Penalty", "Entity")
                        .WithMany()
                        .HasForeignKey("PenaltyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.Placement", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Placements")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlacementChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.Placement", "Entity")
                        .WithMany()
                        .HasForeignKey("PlacementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Entity")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerSeasonData", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("SeasonData")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerSeasonDataChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.PlayerSeasonData", "Entity")
                        .WithMany()
                        .HasForeignKey("PlayerId", "Season")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.Table", "Entity")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableScore", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("TableScores")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lounge.Web.Models.Table", "Table")
                        .WithMany("Scores")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableScoreChange", b =>
                {
                    b.HasOne("Lounge.Web.Models.TableScore", "Entity")
                        .WithMany()
                        .HasForeignKey("TableId", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("Lounge.Web.Models.Player", b =>
                {
                    b.Navigation("Bonuses");

                    b.Navigation("Penalties");

                    b.Navigation("Placements");

                    b.Navigation("SeasonData");

                    b.Navigation("TableScores");
                });

            modelBuilder.Entity("Lounge.Web.Models.Table", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
