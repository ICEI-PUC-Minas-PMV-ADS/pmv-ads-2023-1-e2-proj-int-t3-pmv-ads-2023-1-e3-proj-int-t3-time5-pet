using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_adocao.Migrations
{
    /// <inheritdoc />
    public partial class M01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Login);
                });

            migrationBuilder.CreateTable(
                name: "Requerente",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerente", x => x.Login);
                    table.ForeignKey(
                        name: "FK_Requerente_Usuarios_Login",
                        column: x => x.Login,
                        principalTable: "Usuarios",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Contato = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.Login);
                    table.ForeignKey(
                        name: "FK_Responsavel_Usuarios_Login",
                        column: x => x.Login,
                        principalTable: "Usuarios",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Historico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sexo = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pets_Responsavel_Dono",
                        column: x => x.Dono,
                        principalTable: "Responsavel",
                        principalColumn: "Login");
                });

            migrationBuilder.CreateTable(
                name: "Adocao",
                columns: table => new
                {
                    AdocaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Adotante = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IdPet = table.Column<int>(type: "int", nullable: true),
                    ResponsavelLogin = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adocao", x => x.AdocaoId);
                    table.ForeignKey(
                        name: "FK_Adocao_Pets_IdPet",
                        column: x => x.IdPet,
                        principalTable: "Pets",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Adocao_Requerente_Adotante",
                        column: x => x.Adotante,
                        principalTable: "Requerente",
                        principalColumn: "Login");
                    table.ForeignKey(
                        name: "FK_Adocao_Responsavel_ResponsavelLogin",
                        column: x => x.ResponsavelLogin,
                        principalTable: "Responsavel",
                        principalColumn: "Login");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adocao_Adotante",
                table: "Adocao",
                column: "Adotante");

            migrationBuilder.CreateIndex(
                name: "IX_Adocao_IdPet",
                table: "Adocao",
                column: "IdPet");

            migrationBuilder.CreateIndex(
                name: "IX_Adocao_ResponsavelLogin",
                table: "Adocao",
                column: "ResponsavelLogin");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_Dono",
                table: "Pets",
                column: "Dono");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adocao");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Requerente");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
