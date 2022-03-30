using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FicticiusClean.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_veiculo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    consumoCidade = table.Column<double>(type: "float", nullable: false),
                    consumoEstrada = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_veiculo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_veiculo");
        }
    }
}
