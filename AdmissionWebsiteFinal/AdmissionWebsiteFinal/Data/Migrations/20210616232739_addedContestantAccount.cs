using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class addedContestantAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContestantId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ContestantId",
                table: "AspNetUsers",
                column: "ContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Contestants_ContestantId",
                table: "AspNetUsers",
                column: "ContestantId",
                principalTable: "Contestants",
                principalColumn: "ContestantId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Contestants_ContestantId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ContestantId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ContestantId",
                table: "AspNetUsers");
        }
    }
}
