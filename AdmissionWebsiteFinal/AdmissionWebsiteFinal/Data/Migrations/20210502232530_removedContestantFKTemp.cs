using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class removedContestantFKTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_Contestants_ContestantId",
                table: "AdmissionEntries");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionEntries_ContestantId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "ContestantId",
                table: "AdmissionEntries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContestantId",
                table: "AdmissionEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_ContestantId",
                table: "AdmissionEntries",
                column: "ContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Contestants_ContestantId",
                table: "AdmissionEntries",
                column: "ContestantId",
                principalTable: "Contestants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
