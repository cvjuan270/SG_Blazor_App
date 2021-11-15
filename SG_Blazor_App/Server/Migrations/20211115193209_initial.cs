using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SG_Blazor_App.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atenciones",
                columns: table => new
                {
                    IdAtenciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Local0 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipExa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FecAte = table.Column<DateTime>(type: "date", nullable: true),
                    NomApe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DocIde = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Empres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubCon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Proyec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PueTra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PeReAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: true),
                    AleMed = table.Column<int>(type: "int", nullable: true),
                    AleAud = table.Column<int>(type: "int", nullable: true),
                    AleEnf = table.Column<int>(type: "int", nullable: true),
                    AlEnHc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Atenciones", x => x.IdAtenciones);
                });

            migrationBuilder.CreateTable(
                name: "especialidadMedica",
                columns: table => new
                {
                    IdEspeMedic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidadMedica", x => x.IdEspeMedic);
                });

            migrationBuilder.CreateTable(
                name: "admisions",
                columns: table => new
                {
                    IdAdmi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAtenciones = table.Column<int>(type: "int", nullable: false),
                    HorIng = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HorReg = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HorSal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pendie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EnvAsi = table.Column<bool>(type: "bit", nullable: false),
                    EnvApt = table.Column<bool>(type: "bit", nullable: false),
                    FecEnvResMed = table.Column<DateTime>(type: "date", nullable: true),
                    FecEnvResEmp = table.Column<DateTime>(type: "date", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admisions", x => x.IdAdmi);
                    table.ForeignKey(
                        name: "FK_admisions_Atenciones_IdAtenciones",
                        column: x => x.IdAtenciones,
                        principalTable: "Atenciones",
                        principalColumn: "IdAtenciones",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "interconsultas",
                columns: table => new
                {
                    IdInter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAtenciones = table.Column<int>(type: "int", nullable: false),
                    Descri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FecEnv = table.Column<DateTime>(type: "date", nullable: true),
                    PeEnCo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnHoIn = table.Column<bool>(type: "bit", nullable: false),
                    FeCoPa = table.Column<DateTime>(type: "date", nullable: true),
                    PeCoPa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FeLeObs = table.Column<DateTime>(type: "date", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interconsultas", x => x.IdInter);
                    table.ForeignKey(
                        name: "FK_interconsultas_Atenciones_IdAtenciones",
                        column: x => x.IdAtenciones,
                        principalTable: "Atenciones",
                        principalColumn: "IdAtenciones",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_admisions_IdAtenciones",
                table: "admisions",
                column: "IdAtenciones");

            migrationBuilder.CreateIndex(
                name: "IX_interconsultas_IdAtenciones",
                table: "interconsultas",
                column: "IdAtenciones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admisions");

            migrationBuilder.DropTable(
                name: "especialidadMedica");

            migrationBuilder.DropTable(
                name: "interconsultas");

            migrationBuilder.DropTable(
                name: "Atenciones");
        }
    }
}
