using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUD_CodeFirstCoursesDataBase_WEBAPI_day3.Migrations
{
    /// <inheritdoc />
    public partial class creatingDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    crs_desc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "ID", "Crs_name", "Duration", "crs_desc" },
                values: new object[,]
                {
                    { 1, "Introduction to Programming", 30, "Basic programming concepts" },
                    { 2, "Data Structures", 40, "Learn various data structures" },
                    { 3, "Web Development", 45, "Building web applications" },
                    { 4, "Database Management", 35, "Fundamentals of database systems" },
                    { 5, "Machine Learning", 50, "Introduction to machine learning concepts" },
                    { 6, "Embedded Systems", 25, "Basics of embedded system design" },
                    { 7, "Cloud Computing", 40, "Introduction to cloud services" },
                    { 8, "Cybersecurity Basics", 30, "Foundations of cybersecurity" },
                    { 9, "Artificial Intelligence", 55, "AI concepts and applications" },
                    { 10, "Networking Essentials", 20, "Fundamentals of networking" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
