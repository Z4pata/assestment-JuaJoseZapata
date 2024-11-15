using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToDoctorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "user_id", "status" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 10, 16, 743, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 10, 16, 743, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 10, 16, 863, DateTimeKind.Local).AddTicks(83), "$2a$11$jDoL1Iy2QoNC8oWno98W..Cjqj8Yg4OS3QBw/PsaoPLm4CcTlZ9Oi" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 10, 16, 983, DateTimeKind.Local).AddTicks(6223), "$2a$11$koC9CJomS.oO90vEPgt91ukCCsCqIaRuoxLe6Nwh9CKsV7GSOpUGS" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "user_id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 5, 3, 711, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 5, 3, 711, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 5, 3, 829, DateTimeKind.Local).AddTicks(4072), "$2a$11$Prmkq1udLkfzPzjclyn22e.4MciHPjkJAMozOpXZodBnBm1KPAmCi" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 5, 3, 948, DateTimeKind.Local).AddTicks(4014), "$2a$11$UyJ1RHpMoUu6fwbrklO4bOUmzqY/vGf4ZbIPw4xSAG8sEzHXqElS6" });
        }
    }
}
