using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_carros",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    montadora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    placa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_carros", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_carros");
        }
    }
}
