﻿// <auto-generated />
using System;
using Lounge.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lounge.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Lounge.Web.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("Lounge.Web.Models.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("Lounge.Web.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("InitialMmr")
                        .HasColumnType("int");

                    b.Property<int>("MKCId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxMmr")
                        .HasColumnType("int");

                    b.Property<int?>("Mmr")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("PlacedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MKCId")
                        .IsUnique();

                    b.HasIndex("NormalizedName")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Lounge.Web.Models.PlayerStat", b =>
                {
                    b.Property<int>("EventsPlayed")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("LargestGain")
                        .HasColumnType("int");

                    b.Property<int?>("LargestLoss")
                        .HasColumnType("int");

                    b.Property<int?>("LastTenGainLoss")
                        .HasColumnType("int");

                    b.Property<int>("LastTenLosses")
                        .HasColumnType("int");

                    b.Property<int>("LastTenWins")
                        .HasColumnType("int");

                    b.Property<int?>("MaxMmr")
                        .HasColumnType("int");

                    b.Property<int?>("Mmr")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.ToView("View_PlayerStats");
                });

            modelBuilder.Entity("Lounge.Web.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumTeams")
                        .HasColumnType("int");

                    b.Property<string>("TableImageData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TableMessageId")
                        .HasColumnType("int");

                    b.Property<string>("Tier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdateMessageId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tables");
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

            modelBuilder.Entity("Lounge.Web.Models.Bonus", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Bonuses")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
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

            modelBuilder.Entity("Lounge.Web.Models.Player", b =>
                {
                    b.Navigation("Bonuses");

                    b.Navigation("Penalties");

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
