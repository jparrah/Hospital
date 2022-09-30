using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(100)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(10)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Id_Medico = table.Column<int>(type: "int", nullable: false),
                    HospitallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consulta_Hospital_HospitallId",
                        column: x => x.HospitallId,
                        principalTable: "Hospital",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(100)", nullable: false),
                    Especialidad = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    HospitallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medico_Hospital_HospitallId",
                        column: x => x.HospitallId,
                        principalTable: "Hospital",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConsultaPaciente",
                columns: table => new
                {
                    consultasId = table.Column<int>(type: "int", nullable: false),
                    pacientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaPaciente", x => new { x.consultasId, x.pacientesId });
                    table.ForeignKey(
                        name: "FK_ConsultaPaciente_Consulta_consultasId",
                        column: x => x.consultasId,
                        principalTable: "Consulta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultaPaciente_Paciente_pacientesId",
                        column: x => x.pacientesId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultaPacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Consulta = table.Column<int>(type: "int", nullable: false),
                    Id_Paciente = table.Column<int>(type: "int", nullable: false),
                    Tratamiento = table.Column<string>(type: "varchar(100)", nullable: false),
                    FechaCitaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inicial = table.Column<bool>(type: "bit", nullable: false),
                    FechaCitaProxima = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsultaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaPacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultaPacientes_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_HospitallId",
                table: "Consulta",
                column: "HospitallId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaPaciente_pacientesId",
                table: "ConsultaPaciente",
                column: "pacientesId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaPacientes_ConsultaId",
                table: "ConsultaPacientes",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_HospitallId",
                table: "Medico",
                column: "HospitallId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultaPaciente");

            migrationBuilder.DropTable(
                name: "ConsultaPacientes");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
