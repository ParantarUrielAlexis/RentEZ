using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class DisableForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Disable foreign key constraints
            migrationBuilder.Sql("PRAGMA foreign_keys = 0;", suppressTransaction: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Re-enable foreign key constraints
            migrationBuilder.Sql("PRAGMA foreign_keys = 1;", suppressTransaction: true);

        }
    }
}
