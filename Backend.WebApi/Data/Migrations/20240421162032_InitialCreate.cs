using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.WebApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NAME",
                columns: table => new
                {
                    NAME_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NAME_AUTH = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NAME_FIRST = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    NAME_LAST = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NAME", x => x.NAME_ID);
                });

            migrationBuilder.CreateTable(
                name: "SB",
                columns: table => new
                {
                    SB_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SB_NAME_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    SB_PASSWORT = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SB_REMEMBERME = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SB", x => x.SB_ID);
                    table.ForeignKey(
                        name: "FK_SB_NAME_SB_NAME_ID",
                        column: x => x.SB_NAME_ID,
                        principalTable: "NAME",
                        principalColumn: "NAME_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SB_SB_NAME_ID",
                table: "SB",
                column: "SB_NAME_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SB");

            migrationBuilder.DropTable(
                name: "NAME");
        }
    }
}
