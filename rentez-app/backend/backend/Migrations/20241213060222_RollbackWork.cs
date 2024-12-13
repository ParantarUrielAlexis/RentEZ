using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class RollbackWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bathroom",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Bedroom",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "GeneralPolicy",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageUrl1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageUrl3",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageUrl4",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Person",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Proximity",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Properties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Bathroom",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Bedroom",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "GeneralPolicy",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl4",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Person",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Proximity",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
