using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfTesting.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "fec");

            migrationBuilder.CreateTable(
                name: "FormBase",
                schema: "fec",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormType = table.Column<byte>(type: "tinyint", nullable: true),
                    FormSubtype = table.Column<short>(type: "smallint", nullable: true),
                    FecFilingId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsAmendment = table.Column<bool>(type: "bit", nullable: false),
                    AmendmentNum = table.Column<short>(type: "smallint", nullable: false),
                    ReportPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    ValidationResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilingCommitteeEntityType = table.Column<byte>(type: "tinyint", nullable: false),
                    FilingCommitteeFecId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FilingCommitteeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FilingCommitteeAddressLine1 = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false),
                    FilingCommitteeAddressLine2 = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false),
                    FilingCommitteeCity = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FilingCommitteeState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FilingCommitteePostalCode = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    TreasurerFirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TreasurerMiddleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TreasurerLastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TreasurerPrefix = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TreasurerSuffix = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormBase", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Form99",
                schema: "fec",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false),
                    DocumentType = table.Column<byte>(type: "tinyint", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form99", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Form99_FormBase_UniqueId",
                        column: x => x.UniqueId,
                        principalSchema: "fec",
                        principalTable: "FormBase",
                        principalColumn: "UniqueId");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form99",
                schema: "fec");

            migrationBuilder.DropTable(
                name: "FormBase",
                schema: "fec");
        }
    }
}
