﻿// <auto-generated />
using System;
using Garden.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Garden.Migrations
{
    [DbContext(typeof(GardenContext))]
    partial class GardenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Garden.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Garden.Models.Plot", b =>
                {
                    b.Property<int>("PlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<int>("Hardiness")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Privacy")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Soil")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sun")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("PlotId");

                    b.HasIndex("UserId");

                    b.ToTable("Plots");

                    b.HasData(
                        new
                        {
                            PlotId = 1,
                            Depth = 0,
                            Hardiness = 1,
                            Length = 6,
                            Name = "Small Plot",
                            Soil = "Dirty",
                            Sun = "Bright",
                            Width = 6
                        },
                        new
                        {
                            PlotId = 2,
                            Depth = 0,
                            Hardiness = 2,
                            Length = 12,
                            Name = "Medium Plot",
                            Soil = "Moist",
                            Sun = "Dark",
                            Width = 12
                        },
                        new
                        {
                            PlotId = 3,
                            Depth = 0,
                            Hardiness = 3,
                            Length = 18,
                            Name = "Large Plot",
                            Soil = "Roosevelt",
                            Sun = "Seven",
                            Width = 18
                        });
                });

            modelBuilder.Entity("Garden.Models.Squarefoot", b =>
                {
                    b.Property<int>("SquarefootId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("HarvestDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastWaterDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("NeedsWater")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("PlantDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PlotId")
                        .HasColumnType("int");

                    b.Property<int>("SeedId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("SquarefootId");

                    b.HasIndex("UserId");

                    b.ToTable("Squarefoots");
                });

            modelBuilder.Entity("Garden.Models.Plot", b =>
                {
                    b.HasOne("Garden.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Garden.Models.Squarefoot", b =>
                {
                    b.HasOne("Garden.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
