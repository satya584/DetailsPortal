using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetCoreWebApp.Migrations
{
    public partial class addedUserAdressandUserManagerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAdress",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserManagerName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAdress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserManagerName",
                table: "AspNetUsers");
        }
    }
}
