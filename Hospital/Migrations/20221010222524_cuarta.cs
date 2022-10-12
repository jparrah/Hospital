using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdConsulta",
                table: "Seguimientos");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Seguimientos");

            migrationBuilder.DropColumn(
                name: "IdConsulta",
                table: "Medico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdConsulta",
                table: "Seguimientos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdPaciente",
                table: "Seguimientos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdConsulta",
                table: "Medico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
