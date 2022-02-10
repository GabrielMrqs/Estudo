using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Escola.Infra.Migrations
{
    public partial class vai_dar_certo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBAlunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idade = table.Column<int>(type: "INT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAlunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBProfessores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idade = table.Column<int>(type: "INT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProfessores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBAulas",
                columns: table => new
                {
                    IdAluno = table.Column<int>(type: "int", nullable: false),
                    IdProfessor = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAulas", x => new { x.IdAluno, x.IdProfessor });
                    table.ForeignKey(
                        name: "FK_TBAulas_TBAlunos_IdAluno",
                        column: x => x.IdAluno,
                        principalTable: "TBAlunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBAulas_TBProfessores_IdProfessor",
                        column: x => x.IdProfessor,
                        principalTable: "TBProfessores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAulas_IdProfessor",
                table: "TBAulas",
                column: "IdProfessor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAulas");

            migrationBuilder.DropTable(
                name: "TBAlunos");

            migrationBuilder.DropTable(
                name: "TBProfessores");
        }
    }
}
