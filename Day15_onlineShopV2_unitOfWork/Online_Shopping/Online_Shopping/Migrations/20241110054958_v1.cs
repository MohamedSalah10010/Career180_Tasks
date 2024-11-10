using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Shopping.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Catalogs_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Catalogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "id", "desc", "name" },
                values: new object[,]
                {
                    { 1, "All electronic devices", "Electronics" },
                    { 2, "Collection of books", "Books" },
                    { 3, "Apparel and accessories", "Clothing" },
                    { 4, "Appliances for home use", "Home Appliances" },
                    { 5, "Kids' toys and games", "Toys" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "amount", "cat_id", "desc", "name", "price" },
                values: new object[,]
                {
                    { 1, 15, 1, "High-performance laptop", "Laptop", 999.99000000000001 },
                    { 2, 30, 1, "Latest model smartphone", "Smartphone", 599.99000000000001 },
                    { 3, 50, 2, "Best-selling novel", "Novel", 19.989999999999998 },
                    { 4, 100, 3, "Comfortable cotton T-shirt", "T-shirt", 9.9900000000000002 },
                    { 5, 20, 4, "Kitchen blender with multiple settings", "Blender", 49.990000000000002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_cat_id",
                table: "Products",
                column: "cat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Catalogs");
        }
    }
}
