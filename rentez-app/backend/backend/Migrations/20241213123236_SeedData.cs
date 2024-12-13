using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyID", "City", "Description", "Name", "Price", "Province", "Street", "UserID" },
                values: new object[,]
                {
                    { 1, "Metropolis", "A cozy apartment in the heart of the city.", "Cozy Apartment", 1200.00m, "NY", "123 Main St", 1 },
                    { 2, "Gotham", "A luxurious villa with stunning views.", "Luxury Villa", 5000.00m, "CA", "456 Elm St", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyID",
                keyValue: 2);
        }
    }
}
