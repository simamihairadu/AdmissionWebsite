using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class PopulateDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Departments (Name) VALUES ('Informatica')");
            migrationBuilder.Sql("INSERT INTO Departments (Name) VALUES ('Matematica-Informatica')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
