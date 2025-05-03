using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Temperaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sensor1 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor2 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor3 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor4 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor5 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor6 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor7 = table.Column<double>(type: "REAL", nullable: false),
                    Sensor8 = table.Column<double>(type: "REAL", nullable: false),
                    DataHora = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperaturas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temperaturas");
        }
    }
}
