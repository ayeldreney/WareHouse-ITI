using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class warehousetableaddedupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dismissalNotices",
                columns: table => new
                {
                    DismissalNotice_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DismissalNotice_Date = table.Column<DateTime>(nullable: false),
                    wareHouse_fk = table.Column<int>(nullable: false),
                    supplier_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dismissalNotices", x => x.DismissalNotice_Id);
                    table.ForeignKey(
                        name: "FK_dismissalNotices_Suppliers_supplier_fk",
                        column: x => x.supplier_fk,
                        principalTable: "Suppliers",
                        principalColumn: "Supplier_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dismissalNotices_wareHouses_wareHouse_fk",
                        column: x => x.wareHouse_fk,
                        principalTable: "wareHouses",
                        principalColumn: "WareHouse_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dismissalNotices_supplier_fk",
                table: "dismissalNotices",
                column: "supplier_fk");

            migrationBuilder.CreateIndex(
                name: "IX_dismissalNotices_wareHouse_fk",
                table: "dismissalNotices",
                column: "wareHouse_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dismissalNotices");
        }
    }
}
