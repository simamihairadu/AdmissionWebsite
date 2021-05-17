using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class AddedEntryOptionFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OptionId",
                table: "AdmissionEntries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_OptionId",
                table: "AdmissionEntries",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Options_OptionId",
                table: "AdmissionEntries",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_Options_OptionId",
                table: "AdmissionEntries");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionEntries_OptionId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "AdmissionEntries");
        }
    }
}
