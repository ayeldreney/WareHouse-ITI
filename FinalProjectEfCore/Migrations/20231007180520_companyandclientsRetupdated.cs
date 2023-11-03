using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class companyandclientsRetupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Company_Company_fk",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_Client_Company_fk",
                table: "Clients",
                newName: "IX_Clients_Company_fk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Client_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Company_Company_fk",
                table: "Clients",
                column: "Company_fk",
                principalTable: "Company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Company_Company_fk",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_Company_fk",
                table: "Client",
                newName: "IX_Client_Company_fk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Client_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Company_Company_fk",
                table: "Client",
                column: "Company_fk",
                principalTable: "Company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
