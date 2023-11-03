using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectEfCore.Migrations
{
    public partial class dissmissalnoticeupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DismissalNotice_Date",
                table: "dismissalNotices",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DismissalNotice_Date",
                table: "dismissalNotices",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
