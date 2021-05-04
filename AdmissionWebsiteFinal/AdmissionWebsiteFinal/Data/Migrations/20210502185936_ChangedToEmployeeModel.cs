using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class ChangedToEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_AspNetUsers_ContestantId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ContestantId",
                table: "AdmissionEntries",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "AdmissionEntries",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contestants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contestants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionViewModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_EmployeeId",
                table: "AdmissionEntries",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Contestants_ContestantId",
                table: "AdmissionEntries",
                column: "ContestantId",
                principalTable: "Contestants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_AspNetUsers_EmployeeId",
                table: "AdmissionEntries",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_Contestants_ContestantId",
                table: "AdmissionEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_AspNetUsers_EmployeeId",
                table: "AdmissionEntries");

            migrationBuilder.DropTable(
                name: "Contestants");

            migrationBuilder.DropTable(
                name: "SessionViewModel");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionEntries_EmployeeId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AdmissionEntries");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContestantId",
                table: "AdmissionEntries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_AspNetUsers_ContestantId",
                table: "AdmissionEntries",
                column: "ContestantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
