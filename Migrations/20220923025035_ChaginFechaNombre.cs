using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectEntity.Migrations
{
    public partial class ChaginFechaNombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Fechacreada",
                table: "Tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("74a70252-5c9c-4f39-bb8c-058fe6f02ce0"),
                column: "Fechacreada",
                value: new DateTime(2022, 9, 22, 22, 50, 35, 267, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("dbfc07f7-bebf-4b66-a56f-5e7090f75511"),
                column: "Fechacreada",
                value: new DateTime(2022, 9, 22, 22, 50, 35, 267, DateTimeKind.Local).AddTicks(8822));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fechacreada",
                table: "Tarea");
        }
    }
}
