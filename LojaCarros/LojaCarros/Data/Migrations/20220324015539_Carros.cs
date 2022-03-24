using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaCarros.Data.Migrations
{
    public partial class Carros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    modelo = table.Column<string>(nullable: false),
                    ano = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carros");
        }
    }
}
