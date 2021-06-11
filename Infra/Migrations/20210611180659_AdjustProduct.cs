using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AdjustProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PRD_VALUE",
                table: "Product",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "PRD_STATUS",
                table: "Product",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "PRD_NAME",
                table: "Product",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PRD_ID",
                table: "Product",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Product",
                newName: "PRD_VALUE");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Product",
                newName: "PRD_STATUS");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Product",
                newName: "PRD_NAME");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "PRD_ID");
        }
    }
}
