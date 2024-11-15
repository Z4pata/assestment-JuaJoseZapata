using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SeedersIntoRolesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "id", "creation_date", "name", "update_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 8, 30, 22, 877, DateTimeKind.Local).AddTicks(2022), "doctor", null },
                    { 2, new DateTime(2024, 11, 15, 8, 30, 22, 877, DateTimeKind.Local).AddTicks(2054), "patient", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
