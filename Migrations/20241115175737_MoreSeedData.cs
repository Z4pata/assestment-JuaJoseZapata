using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 12, 57, 37, 183, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 12, 57, 37, 183, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "id", "creation_date", "name", "update_date" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 12, 57, 37, 183, DateTimeKind.Local).AddTicks(2906), "admin", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 57, 37, 302, DateTimeKind.Local).AddTicks(8134), "$2a$11$1AlDtMI4X9QNHcHFK9igwOyFXJNNIjPo/Fh1/p5Xw/ohXGLau6.km" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 57, 37, 421, DateTimeKind.Local).AddTicks(7781), "$2a$11$nnMwq7Wp6v0Ic32ImpsB8.Y2l8uZVu0dqsIJsEL1PtHkSDb6Dm0R." });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "creation_date", "email", "name", "password", "role_id", "update_date" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 12, 57, 37, 540, DateTimeKind.Local).AddTicks(366), "admin@example.com", "el admin", "$2a$11$kFQbnjqAnf6Budhhhgl4quPNVroWje3rBQFQpGo67BzUamBH0boZC", 3, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "id",
                keyValue: 3);

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
    }
}
