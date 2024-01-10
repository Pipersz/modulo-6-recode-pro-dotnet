using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercuryViagens.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "destino",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destino", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "imagem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conteudo = table.Column<byte[]>(type: "longblob", nullable: false),
                    fk_destino_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagem", x => x.id);
                    table.ForeignKey(
                        name: "FK_imagem_destino_fk_destino_id",
                        column: x => x.fk_destino_id,
                        principalTable: "destino",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pacoteviagem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_ida = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_volta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    preco = table.Column<double>(type: "double", nullable: false),
                    num_max_prestacoes = table.Column<int>(type: "int", nullable: false),
                    fk_destino_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacoteviagem", x => x.id);
                    table.ForeignKey(
                        name: "FK_pacoteviagem_destino_fk_destino_id",
                        column: x => x.fk_destino_id,
                        principalTable: "destino",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_imagem_fk_destino_id",
                table: "imagem",
                column: "fk_destino_id");

            migrationBuilder.CreateIndex(
                name: "IX_pacoteviagem_fk_destino_id",
                table: "pacoteviagem",
                column: "fk_destino_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imagem");

            migrationBuilder.DropTable(
                name: "pacoteviagem");

            migrationBuilder.DropTable(
                name: "destino");
        }
    }
}
