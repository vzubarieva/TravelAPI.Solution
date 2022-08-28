using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<City>()
                .HasData(
                    new City
                    {
                        CityId = 1,
                        Name = "Kharkiv",
                        Sightseeing = "Gorky Park",
                        Age = 368,
                        Population = 1433886,
                        Reviews = "Great city!"
                    },
                    new City
                    {
                        CityId = 2,
                        Name = "Seattle",
                        Sightseeing = "Space Needle",
                        Age = 171,
                        Population = 741251,
                        Reviews = "Beautiful city!"
                    },
                    new City
                    {
                        CityId = 3,
                        Name = "New York",
                        Sightseeing = "Central Park",
                        Age = 398,
                        Population = 20365879,
                        Reviews = "Modern city!"
                    },
                    new City
                    {
                        CityId = 4,
                        Name = "Amsterdam",
                        Sightseeing = "Van Gogh Museum",
                        Age = 746,
                        Population = 1166000,
                        Reviews = "Awesome city!"
                    }
                );
        }
    }
}
