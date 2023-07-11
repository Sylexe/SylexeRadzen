using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SylexeRadzen.Migrations
{
    /// <inheritdoc />
    public partial class sylexeReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sylexeReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Timestamp = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sylexeReports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "sylexeReports",
                columns: new[] { "Id", "Name", "Path", "Timestamp" },
                values: new object[] { 1, "Aquasec", "rat.json", "aquasec-trivy_0.34.0-05-juillet-2023-14_36_55" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sylexeReports");
        }
    }
}
