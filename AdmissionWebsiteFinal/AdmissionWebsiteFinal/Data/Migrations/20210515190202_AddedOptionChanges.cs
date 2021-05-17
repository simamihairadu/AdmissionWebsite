using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class AddedOptionChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfSpots",
                table: "Options");

            migrationBuilder.AddColumn<int>(
                name: "LocuriBuget",
                table: "Options",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocuriRomanDePretutindeni",
                table: "Options",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocuriRrom",
                table: "Options",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocuriTaxa",
                table: "Options",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocuriBuget",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "LocuriRomanDePretutindeni",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "LocuriRrom",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "LocuriTaxa",
                table: "Options");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSpots",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
