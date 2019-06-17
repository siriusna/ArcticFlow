using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArcticFlow.Migrations
{
    public partial class ArcticFlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RedesSociais",
                columns: table => new
                {
                    RedeSocialID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Facebook = table.Column<string>(nullable: true),
                    Whatsapp = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Youtube = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSociais", x => x.RedeSocialID);
                });

            migrationBuilder.CreateTable(
                name: "Arctics",
                columns: table => new
                {
                    ArcticID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    Endereco = table.Column<int>(nullable: false),
                    Empresa = table.Column<string>(nullable: true),
                    FotoPerfil = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    RedeSocialID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arctics", x => x.ArcticID);
                    table.ForeignKey(
                        name: "FK_Arctics_RedesSociais_RedeSocialID",
                        column: x => x.RedeSocialID,
                        principalTable: "RedesSociais",
                        principalColumn: "RedeSocialID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descrição = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    ArcticID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaID);
                    table.ForeignKey(
                        name: "FK_Categorias_Arctics_ArcticID",
                        column: x => x.ArcticID,
                        principalTable: "Arctics",
                        principalColumn: "ArcticID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Corpo = table.Column<string>(nullable: false),
                    URLImage = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    RedeSocialID = table.Column<int>(nullable: true),
                    CategoriaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_RedesSociais_RedeSocialID",
                        column: x => x.RedeSocialID,
                        principalTable: "RedesSociais",
                        principalColumn: "RedeSocialID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arctics_RedeSocialID",
                table: "Arctics",
                column: "RedeSocialID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_ArcticID",
                table: "Categorias",
                column: "ArcticID");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoriaID",
                table: "News",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_News_RedeSocialID",
                table: "News",
                column: "RedeSocialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Arctics");

            migrationBuilder.DropTable(
                name: "RedesSociais");
        }
    }
}
