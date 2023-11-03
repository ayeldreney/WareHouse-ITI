using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class warehousetableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_WareHouse_WareHouse_fk",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Company_Company_fk",
                table: "Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_WareHouse_Company_Company_fk",
                table: "WareHouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WareHouse",
                table: "WareHouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "WareHouse",
                newName: "wareHouses");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameIndex(
                name: "IX_WareHouse_Company_fk",
                table: "wareHouses",
                newName: "IX_wareHouses_Company_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Supplier_Company_fk",
                table: "Suppliers",
                newName: "IX_Suppliers_Company_fk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wareHouses",
                table: "wareHouses",
                column: "WareHouse_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Supplier_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_wareHouses_WareHouse_fk",
                table: "Product",
                column: "WareHouse_fk",
                principalTable: "wareHouses",
                principalColumn: "WareHouse_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Company_Company_fk",
                table: "Suppliers",
                column: "Company_fk",
                principalTable: "Company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wareHouses_Company_Company_fk",
                table: "wareHouses",
                column: "Company_fk",
                principalTable: "Company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_wareHouses_WareHouse_fk",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Company_Company_fk",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_wareHouses_Company_Company_fk",
                table: "wareHouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wareHouses",
                table: "wareHouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "wareHouses",
                newName: "WareHouse");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameIndex(
                name: "IX_wareHouses_Company_fk",
                table: "WareHouse",
                newName: "IX_WareHouse_Company_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_Company_fk",
                table: "Supplier",
                newName: "IX_Supplier_Company_fk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WareHouse",
                table: "WareHouse",
                column: "WareHouse_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Supplier_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_WareHouse_WareHouse_fk",
                table: "Product",
                column: "WareHouse_fk",
                principalTable: "WareHouse",
                principalColumn: "WareHouse_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Company_Company_fk",
                table: "Supplier",
                column: "Company_fk",
                principalTable: "Company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WareHouse_Company_Company_fk",
                table: "WareHouse",
                column: "Company_fk",
                principalTable: "Company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
