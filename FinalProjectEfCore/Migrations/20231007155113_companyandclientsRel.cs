using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class companyandclientsRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Client_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(maxLength: 20, nullable: false),
                    Client_Fax = table.Column<string>(nullable: true),
                    Client_Phone = table.Column<string>(nullable: true),
                    Client_EMail = table.Column<string>(maxLength: 20, nullable: false),
                    Client_Website_Url = table.Column<string>(nullable: true),
                    Company_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Client_Id);
                    table.ForeignKey(
                        name: "FK_Client_Company_Company_fk",
                        column: x => x.Company_fk,
                        principalTable: "Company",
                        principalColumn: "Company_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Supplier_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier_Name = table.Column<string>(maxLength: 20, nullable: false),
                    Supplier_Fax = table.Column<string>(nullable: true),
                    Supplier_Phone = table.Column<string>(nullable: true),
                    Supplier_EMail = table.Column<string>(maxLength: 20, nullable: false),
                    Supplier_Website_Url = table.Column<string>(nullable: true),
                    Company_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Supplier_Id);
                    table.ForeignKey(
                        name: "FK_Supplier_Company_Company_fk",
                        column: x => x.Company_fk,
                        principalTable: "Company",
                        principalColumn: "Company_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Company_fk",
                table: "Client",
                column: "Company_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Company_fk",
                table: "Supplier",
                column: "Company_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
