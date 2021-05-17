using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class SeedSpecialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES ('Informatica')");
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES ('Matematica-Informatica')");
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES ('Ecologie si protectia mediului')");
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES ('Biologie')");
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES ('Educatie fizica si sportiva')");
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES ('Sport si performanta motrica')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
