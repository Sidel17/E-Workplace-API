using Microsoft.EntityFrameworkCore.Migrations;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Migrations
{
    public partial class ForeignKeyPayroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PayrollID",
                table: "Payrolls",
                newName: "AccountInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountInformationId",
                table: "Payrolls",
                newName: "PayrollID");
        }
    }
}
