using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PriscilaZuniga_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class PZInicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PZClass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    PZ_Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PZ_Apodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PZ_Activo = table.Column<bool>(type: "bit", nullable: false),
                    PZ_FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PZClass", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PZClass");
        }
    }
}
