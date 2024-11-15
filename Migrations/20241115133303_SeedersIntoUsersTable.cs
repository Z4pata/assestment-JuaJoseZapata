using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SeedersIntoUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 8, 33, 3, 334, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 8, 33, 3, 334, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "creation_date", "email", "name", "password", "role_id", "update_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 8, 33, 3, 453, DateTimeKind.Local).AddTicks(8367), "zapata.devs@gmail.com", "Juan Jose", "$2a$11$Tl5rKjRGgU3fmwxipW8L5OF94MEFSdGTVFqZNRKd92HCfCQMzlEHC", 1, null },
                    { 2, new DateTime(2024, 11, 15, 8, 33, 3, 574, DateTimeKind.Local).AddTicks(5036), "user@example.com", "Test", "$2a$11$IVuUFOhoI2qAJ1tiydiJiesSg6HLu4u3n9GwVThicIkfo7supDQC.", 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 8, 30, 22, 877, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 8, 30, 22, 877, DateTimeKind.Local).AddTicks(2054));
        }
    }
}
