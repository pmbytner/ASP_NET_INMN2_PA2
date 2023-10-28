using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_INMN2_PA2.Migrations
{
    /// <inheritdoc />
    public partial class NowaKolumnaPaństwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Populacja",
                table: "Miasta",
                type: "decimal(10,0)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Państwo",
                table: "Miasta",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Państwo",
                table: "Miasta");

            migrationBuilder.AlterColumn<decimal>(
                name: "Populacja",
                table: "Miasta",
                type: "decimal(20,0)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,0)",
                oldNullable: true);
        }
    }
}
