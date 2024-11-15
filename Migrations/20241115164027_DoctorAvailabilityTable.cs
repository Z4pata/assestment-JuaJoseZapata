using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    /// <inheritdoc />
    public partial class DoctorAvailabilityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "doctors_availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    doctor_id = table.Column<int>(type: "int", nullable: false),
                    weekday = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_time = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    end_time = table.Column<TimeOnly>(type: "time(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors_availabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_doctors_availabilities_doctors_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctors",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_doctors_availabilities_doctor_id",
                table: "doctors_availabilities",
                column: "doctor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctors_availabilities");

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
    }
}
