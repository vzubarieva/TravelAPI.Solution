﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20220828223825_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Travel.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<string>("Reviews")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sightseeing")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Age = 368,
                            Name = "Kharkiv",
                            Population = 1433886,
                            Reviews = "Great city!",
                            Sightseeing = "Gorky Park"
                        },
                        new
                        {
                            CityId = 2,
                            Age = 171,
                            Name = "Seattle",
                            Population = 741251,
                            Reviews = "Beautiful city!",
                            Sightseeing = "Space Needle"
                        },
                        new
                        {
                            CityId = 3,
                            Age = 398,
                            Name = "New York",
                            Population = 20365879,
                            Reviews = "Modern city!",
                            Sightseeing = "Central Park"
                        },
                        new
                        {
                            CityId = 4,
                            Age = 746,
                            Name = "Amsterdam",
                            Population = 1166000,
                            Reviews = "Awesome city!",
                            Sightseeing = "Van Gogh Museum"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}