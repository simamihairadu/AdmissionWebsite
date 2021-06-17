using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class changedEntryOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "EntryOptions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "EntryOptions");
        }
    }
}
