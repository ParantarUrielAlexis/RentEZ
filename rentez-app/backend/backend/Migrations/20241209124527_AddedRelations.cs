using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Bedroom",
                table: "Features",
                newName: "Bedrooms");

            migrationBuilder.RenameColumn(
                name: "Bathroom",
                table: "Features",
                newName: "Bathrooms");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_FeatureID",
                table: "Properties",
                column: "FeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserID",
                table: "Properties",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Features_FeatureID",
                table: "Properties",
                column: "FeatureID",
                principalTable: "Features",
                principalColumn: "FeatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Users_UserID",
                table: "Properties",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Features_FeatureID",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Users_UserID",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_FeatureID",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_UserID",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Bedrooms",
                table: "Features",
                newName: "Bedroom");

            migrationBuilder.RenameColumn(
                name: "Bathrooms",
                table: "Features",
                newName: "Bathroom");

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "Properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
