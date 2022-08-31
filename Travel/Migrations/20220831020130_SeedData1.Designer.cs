﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20220831020130_SeedData1")]
    partial class SeedData1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Travel.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Kharkiv",
                            Country = "Ukraine",
                            Description = "Big park with a lot of amusements",
                            Name = "Gorky Park"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Seattle",
                            Country = "The USA",
                            Description = "A lot of different marine species in one place",
                            Name = "Seattle Aquarium"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "New York",
                            Country = "The USA",
                            Description = "A lot of different Art collections",
                            Name = "The Metropolitan Museum of Art"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "Amsterdam",
                            Country = "Netherlands",
                            Description = "Art museum housing European masterpieces",
                            Name = "Rijksmuseum"
                        });
                });

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ReviewId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Description = "Big park with a lot of amusements",
                            DestinationId = 1,
                            Rating = 5,
                            Title = "My native Gorky Park"
                        },
                        new
                        {
                            ReviewId = 2,
                            Description = "A lot of different marine species in one place",
                            DestinationId = 2,
                            Rating = 3,
                            Title = "Trip to Seattle Aquarium"
                        },
                        new
                        {
                            ReviewId = 3,
                            Description = "A lot of different Art collections",
                            DestinationId = 3,
                            Rating = 4,
                            Title = "Trip to The Metropolitan Museum of Art"
                        },
                        new
                        {
                            ReviewId = 4,
                            Description = "Art museum housing European masterpieces",
                            DestinationId = 4,
                            Rating = 5,
                            Title = "Trip to Rijksmuseum"
                        },
                        new
                        {
                            ReviewId = 5,
                            Description = "Ordered tickets online (entry not timed) each visit brings back the enormity of the MET and need for a strategy.",
                            DestinationId = 3,
                            Rating = 5,
                            Title = "My The Metropolitan Museum of Art"
                        },
                        new
                        {
                            ReviewId = 6,
                            Description = "Really nice and welcoming also the structure and the place, many pictures and sculptures, suggested ",
                            DestinationId = 4,
                            Rating = 3,
                            Title = "Once in Rijksmuseum"
                        });
                });

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.HasOne("Travel.Models.Destination", "Destination")
                        .WithMany("Reviews")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("Travel.Models.Destination", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
