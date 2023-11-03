using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class supplypermisson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplyPermission_Id",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "supplyPermissions",
                columns: table => new
                {
                    SupplyPermission_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyPermission_Date = table.Column<DateTime>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    SupplyPermission_expiry = table.Column<int>(nullable: false),
                    wareHouse_fk = table.Column<int>(nullable: false),
                    supplier_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplyPermissions", x => x.SupplyPermission_Id);
                    table.ForeignKey(
                        name: "FK_supplyPermissions_Suppliers_supplier_fk",
                        column: x => x.supplier_fk,
                        principalTable: "Suppliers",
                        principalColumn: "Supplier_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_supplyPermissions_wareHouses_wareHouse_fk",
                        column: x => x.wareHouse_fk,
                        principalTable: "wareHouses",
                        principalColumn: "WareHouse_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplyPermission_Id",
                table: "Product",
                column: "SupplyPermission_Id");

            migrationBuilder.CreateIndex(
                name: "IX_supplyPermissions_supplier_fk",
                table: "supplyPermissions",
                column: "supplier_fk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_supplyPermissions_wareHouse_fk",
                table: "supplyPermissions",
                column: "wareHouse_fk",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_supplyPermissions_SupplyPermission_Id",
                table: "Product",
                column: "SupplyPermission_Id",
                principalTable: "supplyPermissions",
                principalColumn: "SupplyPermission_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_supplyPermissions_SupplyPermission_Id",
                table: "Product");

            migrationBuilder.DropTable(
                name: "supplyPermissions");

            migrationBuilder.DropIndex(
                name: "IX_Product_SupplyPermission_Id",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SupplyPermission_Id",
                table: "Product");
        }
    }
}
