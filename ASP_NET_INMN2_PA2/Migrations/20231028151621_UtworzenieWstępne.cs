using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_INMN2_PA2.Migrations
{
    /// <inheritdoc />
    public partial class UtworzenieWstępne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Miasta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Województwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataZałożenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Powierzchnia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Populacja = table.Column<decimal>(type: "decimal(20,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miasta", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Miasta");
        }
    }
}
