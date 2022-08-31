using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Big park with a lot of amusements", "My native Gorky Park" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A lot of different marine species in one place", "Trip to Seattle Aquarium" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A lot of different Art collections", "Trip to The Metropolitan Museum of Art" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Art museum housing European masterpieces", "Trip to Rijksmuseum" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Ordered tickets online (entry not timed) each visit brings back the enormity of the MET and need for a strategy.", "My The Metropolitan Museum of Art" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Really nice and welcoming also the structure and the place, many pictures and sculptures, suggested ", "Once in Rijksmuseum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Great city!", "Trip to Kharkiv" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Great city, but a lot of homeless people!", "Trip to Seattle" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Great city, beautiful atmosphere!", "Trip to New York" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Great city! I like it so much. Modern and stylish architecture of the building. A lot of bridges and tulips!", "Trip to Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "There is a reason the old saying goes I Love New York. You probably have to like being in a big city, which I do. The NYC culture, history, restaurants, shopping, parks and activities can keep you busy constantly. ", "My New York" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Amsterdam is a beautiful city. It is very charming.I was however disappointed by the city by and large due to other tourist. I didn't anticipate Amsterdam to be full of college age European rich kids", "Amsterdam" });
        }
    }
}
