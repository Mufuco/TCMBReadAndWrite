using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCMB.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    currencyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    forexBuying = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    forexSelling = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    banknoteBuying = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    banknoteSelling = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_currencyName",
                table: "Currencies",
                column: "currencyName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
