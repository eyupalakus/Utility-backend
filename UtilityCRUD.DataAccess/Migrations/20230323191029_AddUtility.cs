using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtilityCRUD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUtility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSOFFICE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Programing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Languages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilities");
        }
    }
}
