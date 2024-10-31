using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDataBase.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Breif",
                table: "News",
                newName: "Brief");

            migrationBuilder.RenameColumn(
                name: "Breif",
                table: "Authors",
                newName: "Brief");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brief",
                table: "News",
                newName: "Breif");

            migrationBuilder.RenameColumn(
                name: "Brief",
                table: "Authors",
                newName: "Breif");
        }
    }
}
