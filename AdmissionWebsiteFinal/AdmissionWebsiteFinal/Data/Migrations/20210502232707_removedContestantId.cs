using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class removedContestantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contestants",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Contestants");

            migrationBuilder.AddColumn<string>(
                name: "ContestantId",
                table: "Contestants",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contestants",
                table: "Contestants",
                column: "ContestantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contestants",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "ContestantId",
                table: "Contestants");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Contestants",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contestants",
                table: "Contestants",
                column: "Id");
        }
    }
}
