using Microsoft.EntityFrameworkCore.Migrations;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Migrations
{
    public partial class addUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "AccountInformations",
                maxLength: 225,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "AccountInformations");
        }
    }
}
