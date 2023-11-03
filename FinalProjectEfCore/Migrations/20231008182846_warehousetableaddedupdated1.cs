using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class warehousetableaddedupdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SupplyPermission_Date",
                table: "supplyPermissions",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SupplyPermission_Date",
                table: "supplyPermissions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
