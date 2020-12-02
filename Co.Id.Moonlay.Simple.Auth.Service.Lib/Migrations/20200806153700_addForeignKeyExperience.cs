using Microsoft.EntityFrameworkCore.Migrations;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Migrations
{
    public partial class addForeignKeyExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountInformationId",
                table: "WorkingExperiences",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountInformationId",
                table: "WorkingExperiences");
        }
    }
}
