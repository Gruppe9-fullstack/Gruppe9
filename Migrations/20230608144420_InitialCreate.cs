using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gruppe9.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bok",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Tittel = table.Column<string>(type: "TEXT", nullable: false),
                    Forfatter = table.Column<string>(type: "TEXT", nullable: false),
                    Forlag = table.Column<string>(type: "TEXT", nullable: false),
                    Utgitt = table.Column<int>(type: "INTEGER", nullable: false),
                    AntallSider = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bok", x => x.ISBN);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bok");
        }
    }
}
