using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class addedFKBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContestantId",
                table: "AdmissionEntries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_ContestantId",
                table: "AdmissionEntries",
                column: "ContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Contestants_ContestantId",
                table: "AdmissionEntries",
                column: "ContestantId",
                principalTable: "Contestants",
                principalColumn: "ContestantId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
