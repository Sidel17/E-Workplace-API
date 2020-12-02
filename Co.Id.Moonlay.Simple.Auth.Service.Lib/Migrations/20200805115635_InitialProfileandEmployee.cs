using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Migrations
{
    public partial class InitialProfileandEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    Fullname = table.Column<string>(maxLength: 255, nullable: true),
                    EmployeeID = table.Column<string>(maxLength: 255, nullable: true),
                    Dob = table.Column<DateTimeOffset>(nullable: true),
                    Gender = table.Column<string>(maxLength: 6, nullable: true),
                    Religion = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    CoorporateEmail = table.Column<string>(maxLength: 225, nullable: true),
                    Password = table.Column<string>(maxLength: 25, nullable: true),
                    EmployeePhoneNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(maxLength: 25, nullable: true),
                    JoinDate = table.Column<DateTimeOffset>(nullable: true),
                    SkillSet = table.Column<string>(maxLength: 255, nullable: true),
                    AccountId = table.Column<int>(nullable: false),
                    JobTitleName = table.Column<string>(maxLength: 20, nullable: true),
                    Department = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    AssetID = table.Column<int>(nullable: false),
                    AssetNumber = table.Column<int>(nullable: false),
                    AssetType = table.Column<string>(maxLength: 255, nullable: true),
                    AssetName = table.Column<string>(maxLength: 255, nullable: true),
                    FullNameEmployeeAsset = table.Column<string>(nullable: true),
                    AcquisitionDate = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    EducationInfoId = table.Column<int>(nullable: false),
                    Grade = table.Column<string>(maxLength: 25, nullable: true),
                    Institution = table.Column<string>(maxLength: 225, nullable: true),
                    Majors = table.Column<string>(maxLength: 255, nullable: true),
                    YearStart = table.Column<int>(nullable: false),
                    YearEnd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    NameOfContact = table.Column<string>(maxLength: 225, nullable: true),
                    Relationship = table.Column<string>(maxLength: 25, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    FullNameOfFamily = table.Column<string>(maxLength: 255, nullable: true),
                    Relationship = table.Column<string>(maxLength: 20, nullable: true),
                    DOBFamily = table.Column<DateTimeOffset>(nullable: true),
                    Religion = table.Column<string>(maxLength: 15, nullable: true),
                    Gender = table.Column<string>(maxLength: 10, nullable: true),
                    KTPNumber = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformalEducations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    HeldBy = table.Column<string>(maxLength: 255, nullable: true),
                    JobPosition = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTimeOffset>(nullable: true),
                    EndDate = table.Column<DateTimeOffset>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    Certificate = table.Column<bool>(nullable: false),
                    FileURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformalEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    PayrollID = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    Tax = table.Column<int>(nullable: false),
                    BPJSKesehatan = table.Column<int>(nullable: false),
                    BPJSTenagaKerja = table.Column<int>(nullable: false),
                    NPWP = table.Column<int>(nullable: false),
                    NameBankAccount = table.Column<string>(maxLength: 255, nullable: true),
                    Bank = table.Column<string>(maxLength: 15, nullable: true),
                    BankAccountNumber = table.Column<string>(maxLength: 255, nullable: true),
                    BankBranch = table.Column<string>(maxLength: 255, nullable: true),
                    BackDatedPayment = table.Column<DateTimeOffset>(nullable: false),
                    Allowance = table.Column<int>(nullable: false),
                    Incentive = table.Column<int>(nullable: false),
                    PaidLeave = table.Column<int>(nullable: false),
                    UnPaidLeave = table.Column<int>(nullable: false),
                    SalaryPeriod = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    TakeHomePay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkingExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    Company = table.Column<string>(maxLength: 255, nullable: true),
                    JobPositionExperience = table.Column<string>(maxLength: 255, nullable: true),
                    TanggalMulai = table.Column<DateTimeOffset>(nullable: true),
                    TanggalSelesai = table.Column<DateTimeOffset>(nullable: true),
                    Deskripsi = table.Column<string>(maxLength: 255, nullable: true),
                    Sertifikat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingExperiences", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountInformations");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "EducationInfos");

            migrationBuilder.DropTable(
                name: "EmergencyContacts");

            migrationBuilder.DropTable(
                name: "FamilyDatas");

            migrationBuilder.DropTable(
                name: "InformalEducations");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "WorkingExperiences");
        }
    }
}
