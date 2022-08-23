using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Cadastro.Migrations
{
    public partial class ConfigdePessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Pessoas",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Pessoas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Pessoas",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Pessoas",
                newName: "cpf");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Pessoas",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Pessoas",
                type: "varchar(45)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Pessoas",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Pessoas",
                type: "varchar(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "last_update",
                table: "Pessoas",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "last_update",
                table: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Pessoas",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Pessoas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Pessoas",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Pessoas",
                newName: "Cpf");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(14)");
        }
    }
}
