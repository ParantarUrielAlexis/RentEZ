using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class PendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyID",
                keyValue: 1,
                columns: new[] { "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Proximity", "Type" },
                values: new object[] { "", "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyID",
                keyValue: 2,
                columns: new[] { "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Proximity", "Type" },
                values: new object[] { "", "", "", "", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyID",
                keyValue: 1,
                columns: new[] { "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Proximity", "Type" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyID",
                keyValue: 2,
                columns: new[] { "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Proximity", "Type" },
                values: new object[] { null, null, null, null, null, null });
        }
    }
}
