using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gruppe9.Migrations
{
    /// <inheritdoc />
    public partial class BokTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eksemplar",
                columns: table => new
                {
                    EksNr = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eksemplar", x => x.EksNr);
                    table.ForeignKey(
                        name: "FK_Eksemplar_Bok_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Bok",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eksemplar_ISBN",
                table: "Eksemplar",
                column: "ISBN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eksemplar");
        }
    }
}
