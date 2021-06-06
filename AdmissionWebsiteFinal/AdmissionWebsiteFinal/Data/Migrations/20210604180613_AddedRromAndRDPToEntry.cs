using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class AddedRromAndRDPToEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RDPSpot",
                table: "AdmissionEntries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RromSpot",
                table: "AdmissionEntries",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RDPSpot",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "RromSpot",
                table: "AdmissionEntries");
        }
    }
}
