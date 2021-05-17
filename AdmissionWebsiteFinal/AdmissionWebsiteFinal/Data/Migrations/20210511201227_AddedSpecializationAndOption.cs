using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionWebsiteFinal.Data.Migrations
{
    public partial class AddedSpecializationAndOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_Departments_DepartmentId",
                table: "AdmissionEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionEntries_Sessions_SessionId",
                table: "AdmissionEntries");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionEntries_DepartmentId",
                table: "AdmissionEntries");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionEntries_SessionId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "AdmissionEntries");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "AdmissionEntries");

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecializationId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    NumberOfSpots = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Options_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_SessionId",
                table: "Options",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_SpecializationId",
                table: "Options",
                column: "SpecializationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "AdmissionEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "AdmissionEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_DepartmentId",
                table: "AdmissionEntries",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionEntries_SessionId",
                table: "AdmissionEntries",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Departments_DepartmentId",
                table: "AdmissionEntries",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionEntries_Sessions_SessionId",
                table: "AdmissionEntries",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
