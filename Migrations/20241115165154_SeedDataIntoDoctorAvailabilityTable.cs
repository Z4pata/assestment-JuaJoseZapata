using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoDoctorAvailabilityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "status",
                keyValue: null,
                column: "status",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "doctors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "doctors_availabilities",
                columns: new[] { "Id", "doctor_id", "end_time", "start_time", "weekday" },
                values: new object[,]
                {
                    { 1, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)), "monday" },
                    { 2, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)), "tuesday" },
                    { 3, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)), "wednesday" },
                    { 4, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)), "thursday" },
                    { 5, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(10)), "friday" }
                });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 11, 51, 54, 110, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 11, 51, 54, 110, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 54, 229, DateTimeKind.Local).AddTicks(2499), "$2a$11$Vt48m4OlQKYb4s/I8lM5hOEmrd0BodTFKfryfC0niLMFOyQwfO7gW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 54, 350, DateTimeKind.Local).AddTicks(4086), "$2a$11$GU4DASkDuPfqatIE1mJ8funnNkYpzS82RHK10fwT/jQ3jvfO66LpC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 11, 40, 26, 856, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 11, 40, 26, 856, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 40, 26, 974, DateTimeKind.Local).AddTicks(5300), "$2a$11$6MHZd24BxUsdjgZsAA0wW.rsTYwxXba9BZDPaz.aPHnZE39nZFbbq" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 40, 27, 94, DateTimeKind.Local).AddTicks(9698), "$2a$11$NE1G.k/TqNw9UouZnd2suOOiNsPyagBq5wSPs/tl9yLV5SBFc4Yz6" });
        }
    }
}
