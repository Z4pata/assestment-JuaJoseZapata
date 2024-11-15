using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class DoctorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_doctors_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctors");

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

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 33, 3, 453, DateTimeKind.Local).AddTicks(8367), "$2a$11$Tl5rKjRGgU3fmwxipW8L5OF94MEFSdGTVFqZNRKd92HCfCQMzlEHC" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 33, 3, 574, DateTimeKind.Local).AddTicks(5036), "$2a$11$IVuUFOhoI2qAJ1tiydiJiesSg6HLu4u3n9GwVThicIkfo7supDQC." });
        }
    }
}
