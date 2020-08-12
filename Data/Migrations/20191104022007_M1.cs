using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "2f776a56-b106-4d9a-90fc-147d80d1cf65", "Jane", "Smith", "Medicine" },
                    { "066ac05d-628f-477e-9471-071dc4bca2a0", "John", "Fisher", "Engineering" },
                    { "e5349cc2-2401-43ea-bc62-34f8192349c4", "Pamela", "Baker", "Food Science" },
                    { "582f6939-6924-41e2-a304-2b329a8b0e01", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
