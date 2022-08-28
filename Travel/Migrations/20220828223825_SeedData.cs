using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Age", "Name", "Population", "Reviews", "Sightseeing" },
                values: new object[,]
                {
                    { 1, 368, "Kharkiv", 1433886, "Great city!", "Gorky Park" },
                    { 2, 171, "Seattle", 741251, "Beautiful city!", "Space Needle" },
                    { 3, 398, "New York", 20365879, "Modern city!", "Central Park" },
                    { 4, 746, "Amsterdam", 1166000, "Awesome city!", "Van Gogh Museum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);
        }
    }
}
