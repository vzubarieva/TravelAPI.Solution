using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder
            //     .Entity<Country>()
            //     .HasData(
            //         new Country { CountryId = 1, Name = "Ukraine", },
            //         new Country { CountryId = 2, Name = "The USA", },
            //         new Country { CountryId = 3, Name = "Netherlands", }
            //     );
            // builder
            //     .Entity<City>()
            //     .HasData(
            //         new City
            //         {
            //             CityId = 1,
            //             Name = "Kharkiv",
            //             Sightseeing = "Gorky Park",
            //             Age = 368,
            //             Population = 1433886,
            //         },
            //         new City
            //         {
            //             CityId = 2,
            //             Name = "Seattle",
            //             Sightseeing = "Space Needle",
            //             Age = 171,
            //             Population = 741251,
            //         },
            //         new City
            //         {
            //             CityId = 3,
            //             Name = "New York",
            //             Sightseeing = "Central Park",
            //             Age = 398,
            //             Population = 20365879,
            //         },
            //         new City
            //         {
            //             CityId = 4,
            //             Name = "Amsterdam",
            //             Sightseeing = "Van Gogh Museum",
            //             Age = 746,
            //             Population = 1166000,
            //         }
            //     );
            builder
                .Entity<Destination>()
                .HasData(
                    new Destination
                    {
                        DestinationId = 1,
                        Name = "Gorky Park",
                        Description = "Big park with a lot of amusements",
                        City = "Kharkiv",
                        Country = "Ukraine"
                    },
                    new Destination
                    {
                        DestinationId = 2,
                        Name = "Seattle Aquarium",
                        Description = "A lot of different marine species in one place",
                        City = "Seattle",
                        Country = "The USA"
                    },
                    new Destination
                    {
                        DestinationId = 3,
                        Name = "The Metropolitan Museum of Art",
                        Description = "A lot of different Art collections",
                        City = "New York",
                        Country = "The USA"
                    },
                    new Destination
                    {
                        DestinationId = 4,
                        Name = "Rijksmuseum",
                        Description = "Art museum housing European masterpieces",
                        City = "Amsterdam",
                        Country = "Netherlands"
                    }
                );
            builder
                .Entity<Review>()
                .HasData(
                    new Review
                    {
                        ReviewId = 1,
                        Title = "My native Gorky Park",
                        Description = "Big park with a lot of amusements",
                        Rating = 5,
                        DestinationId = 1
                    },
                    new Review
                    {
                        ReviewId = 2,
                        Title = "Trip to Seattle Aquarium",
                        Description = "A lot of different marine species in one place",
                        Rating = 3,
                        DestinationId = 2
                    },
                    new Review
                    {
                        ReviewId = 3,
                        Title = "Trip to The Metropolitan Museum of Art",
                        Description = "A lot of different Art collections",
                        Rating = 4,
                        DestinationId = 3
                    },
                    new Review
                    {
                        ReviewId = 4,
                        Title = "Trip to Rijksmuseum",
                        Description = "Art museum housing European masterpieces",
                        Rating = 5,
                        DestinationId = 4
                    },
                    new Review
                    {
                        ReviewId = 5,
                        Title = "My The Metropolitan Museum of Art",
                        Description =
                            "Ordered tickets online (entry not timed) each visit brings back the enormity of the MET and need for a strategy.",
                        Rating = 5,
                        DestinationId = 3
                    },
                    new Review
                    {
                        ReviewId = 6,
                        Title = "Once in Rijksmuseum",
                        Description =
                            "Really nice and welcoming also the structure and the place, many pictures and sculptures, suggested ",
                        Rating = 3,
                        DestinationId = 4
                    }
                );
        }
    }
}
