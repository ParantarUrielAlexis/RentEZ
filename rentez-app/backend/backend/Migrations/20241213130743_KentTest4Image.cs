using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class KentTest4Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Properties",
                newName: "ImageUrl4");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl1",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl3",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageUrl3",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "ImageUrl4",
                table: "Properties",
                newName: "ImageUrl");
        }
    }
}
