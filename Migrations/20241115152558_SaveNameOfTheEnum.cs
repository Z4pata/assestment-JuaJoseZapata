using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class SaveNameOfTheEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "user_id",
                keyValue: 1,
                column: "status",
                value: "available");

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 25, 58, 83, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 15, 10, 25, 58, 83, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 25, 58, 202, DateTimeKind.Local).AddTicks(7758), "$2a$11$6K41s5B5.NwRd2ZvBZMece.SIK2YLcHlX0IyyYw44Do9uusdiHLZu" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 25, 58, 322, DateTimeKind.Local).AddTicks(7563), "$2a$11$ouWQn96qKV0jP91qPRd5G.oIYM1OaXzCBd1KEn9broRkzH0fuydhm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "doctors",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "user_id",
                keyValue: 1,
                column: "status",
                value: 0);

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
    }
}
