using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Shopping.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "photo",
                table: "Products",
                newName: "photoPath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "photoPath",
                table: "Products",
                newName: "photo");
        }
    }
}
