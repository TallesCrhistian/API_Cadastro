using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Cadastro.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    nome = table.Column<string>(type: "varchar(45)", nullable: false),
                    email = table.Column<string>(type: "varchar(40)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(15)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
