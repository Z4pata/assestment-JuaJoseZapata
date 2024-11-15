using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoPatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "patients",
                column: "user_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 35, 0, 475, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 35, 0, 475, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 35, 0, 594, DateTimeKind.Local).AddTicks(508), "$2a$11$vaS.10P3zWLE6Hd7z3vXEuuBFqp6C1loHTh0JMQQaDETM8qTzqiM." });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 35, 0, 713, DateTimeKind.Local).AddTicks(1646), "$2a$11$NC4PJbRi2wxYgOhN775JhO/xckWBdbrOJzWbe5Wsm47UqugCJ0XJO" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "user_id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 33, 27, 973, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 33, 27, 973, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 33, 28, 94, DateTimeKind.Local).AddTicks(6907), "$2a$11$kiJBYxHvYZ1XdRrCgGa18ebZ79vyrj2Q0XuZZsEZmgYLpm0yknQY." });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 33, 28, 217, DateTimeKind.Local).AddTicks(5204), "$2a$11$ygD4TgmrAfF0Io2op5wKlOw68qiOAezNq9gZ2GIUTvisLZIIxoBSe" });
        }
    }
}
