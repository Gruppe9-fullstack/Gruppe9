using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gruppe9.Migrations.Eksemplar
{
    /// <inheritdoc />
    public partial class EksemplarTable : Migration
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
                    UtgittÅr = table.Column<int>(type: "INTEGER", nullable: false),
                    AntallSider = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bok", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Eksemplar",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    EksNr = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eksemplar", x => new { x.ISBN, x.EksNr });
                    table.ForeignKey(
                        name: "FK_Eksemplar_Bok_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Bok",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eksemplar");

            migrationBuilder.DropTable(
                name: "Bok");
        }
    }
}
