using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class AddedSession_Entry_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "AdmissionEntries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_SessionId",
                table: "AdmissionEntries",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Sessions_SessionId",
                table: "AdmissionEntries",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_Sessions_SessionId",
                table: "AdmissionEntries");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionEntries_SessionId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "AdmissionEntries");
        }
    }
}
