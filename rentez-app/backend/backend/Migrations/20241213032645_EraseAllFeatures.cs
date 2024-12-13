using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class EraseAllFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Features_FeatureID",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Properties_FeatureID",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FeatureID",
                table: "Properties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeatureID",
                table: "Properties",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bathrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    Bedrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    GeneralPolicy = table.Column<string>(type: "TEXT", nullable: false),
                    Proximity = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_FeatureID",
                table: "Properties",
                column: "FeatureID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Features_FeatureID",
                table: "Properties",
                column: "FeatureID",
                principalTable: "Features",
                principalColumn: "FeatureID");
        }
    }
}
