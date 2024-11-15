using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoDoctorAvailabilityTable20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(14, 0, 0), new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(14, 0, 0), new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(14, 0, 0), new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(14, 0, 0), new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(14, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 11, 59, 19, 693, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 11, 59, 19, 693, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 59, 19, 811, DateTimeKind.Local).AddTicks(9781), "$2a$11$LFgx1DXLlsdQLJdDsV1BVO63bCQ8fPoCpeBWbRDOzRqfwmwNTswtq" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 59, 19, 931, DateTimeKind.Local).AddTicks(4377), "$2a$11$BbCMXdsP6UHcxmmiMerOOeRUIwwO/MH7tGH3oxrOpv6XpA/iYIbW2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(6)) });

            migrationBuilder.UpdateData(
                table: "doctors_availabilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "end_time", "start_time" },
                values: new object[] { new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(14)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(10)) });

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
    }
}
