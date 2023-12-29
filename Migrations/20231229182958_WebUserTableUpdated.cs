using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ders4.Migrations
{
    public partial class WebUserTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "WebUsers",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "WebUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "WebUsers");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "WebUsers",
                newName: "EmailAddress");
        }
    }
}
