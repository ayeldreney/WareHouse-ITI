using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class unitofMeasurementaddedupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitOfMesurement_Id",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UnitOfMesurement",
                columns: table => new
                {
                    UnitOfMesurement_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitOfMesurement_Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMesurement", x => x.UnitOfMesurement_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnit",
                columns: table => new
                {
                    Product_Id = table.Column<int>(nullable: false),
                    UnitOfMesurement_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnit", x => new { x.Product_Id, x.UnitOfMesurement_Id });
                    table.ForeignKey(
                        name: "FK_ProductUnit_Product_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductUnit_UnitOfMesurement_UnitOfMesurement_Id",
                        column: x => x.UnitOfMesurement_Id,
                        principalTable: "UnitOfMesurement",
                        principalColumn: "UnitOfMesurement_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitOfMesurement_Id",
                table: "Product",
                column: "UnitOfMesurement_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_UnitOfMesurement_Id",
                table: "ProductUnit",
                column: "UnitOfMesurement_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMesurement_UnitOfMesurement_Id",
                table: "Product",
                column: "UnitOfMesurement_Id",
                principalTable: "UnitOfMesurement",
                principalColumn: "UnitOfMesurement_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMesurement_UnitOfMesurement_Id",
                table: "Product");

            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.DropTable(
                name: "UnitOfMesurement");

            migrationBuilder.DropIndex(
                name: "IX_Product_UnitOfMesurement_Id",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UnitOfMesurement_Id",
                table: "Product");
        }
    }
}
