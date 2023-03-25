using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetCoreWebApp.Migrations
{
    public partial class addedadressandmanagerNametoApplicationuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "managerName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "managerName",
                table: "AspNetUsers");
        }
    }
}
