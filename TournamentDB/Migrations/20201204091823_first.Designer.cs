﻿// <auto-generated />
using System;
using IndrivoDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TournamentDB.Migrations
{
    [DbContext(typeof(TournamentDBContext))]
    [Migration("20201204091823_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("IndrivoDataBase.Couch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sallary")
                        .HasColumnType("int");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("Couch");
                });

            modelBuilder.Entity("IndrivoDataBase.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sallary")
                        .HasColumnType("int");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("IndrivoDataBase.PlayerTitle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TitleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TitleId");

                    b.ToTable("PlayerTitle");
                });

            modelBuilder.Entity("IndrivoDataBase.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FoundationYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("IndrivoDataBase.Title", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("IndrivoDataBase.Couch", b =>
                {
                    b.HasOne("IndrivoDataBase.Team", "Team")
                        .WithOne("Couch")
                        .HasForeignKey("IndrivoDataBase.Couch", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("IndrivoDataBase.Player", b =>
                {
                    b.HasOne("IndrivoDataBase.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("IndrivoDataBase.PlayerTitle", b =>
                {
                    b.HasOne("IndrivoDataBase.Player", "Player")
                        .WithMany("PlayerTitles")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndrivoDataBase.Title", "Title")
                        .WithMany("TitlePlayers")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("IndrivoDataBase.Player", b =>
                {
                    b.Navigation("PlayerTitles");
                });

            modelBuilder.Entity("IndrivoDataBase.Team", b =>
                {
                    b.Navigation("Couch");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("IndrivoDataBase.Title", b =>
                {
                    b.Navigation("TitlePlayers");
                });
#pragma warning restore 612, 618
        }
    }
}