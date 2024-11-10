using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Shopping.Migrations
{
    /// <inheritdoc />
    public partial class V3addPhotoColoumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "photo",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photo",
                table: "Products");
        }
    }
}
