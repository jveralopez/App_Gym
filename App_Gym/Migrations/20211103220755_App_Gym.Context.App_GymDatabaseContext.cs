using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App_Gym.Migrations
{
    public partial class App_GymContextApp_GymDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true),
                    habilitado = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    IdEmpleado = table.Column<int>(nullable: true),
                    IdSocio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    idActividad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantTurnos = table.Column<int>(nullable: false),
                    cantTurnosDisponibles = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    horario = table.Column<DateTime>(nullable: false),
                    profesorid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.idActividad);
                    table.ForeignKey(
                        name: "FK_Actividades_Personas_profesorid",
                        column: x => x.profesorid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    IdTurno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<DateTime>(nullable: false),
                    Horario = table.Column<string>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    Socioid = table.Column<int>(nullable: true),
                    ActividadidActividad = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.IdTurno);
                    table.ForeignKey(
                        name: "FK_Turnos_Actividades_ActividadidActividad",
                        column: x => x.ActividadidActividad,
                        principalTable: "Actividades",
                        principalColumn: "idActividad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turnos_Personas_Socioid",
                        column: x => x.Socioid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_profesorid",
                table: "Actividades",
                column: "profesorid");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_ActividadidActividad",
                table: "Turnos",
                column: "ActividadidActividad");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_Socioid",
                table: "Turnos",
                column: "Socioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
