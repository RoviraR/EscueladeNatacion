using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmithSwimmingSchoolApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 8, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 12, 9, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 13, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 12, 14, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 10, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 12, 11, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 16, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 12, 17, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 18, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8709), new DateTime(2024, 12, 19, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 12, 22, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 19, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 12, 20, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 12, 26, 20, 54, 53, 195, DateTimeKind.Local).AddTicks(8717) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 8, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9605), new DateTime(2024, 12, 9, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 13, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 12, 14, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 10, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 12, 11, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 16, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9616), new DateTime(2024, 12, 17, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 18, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 12, 19, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9623), new DateTime(2024, 12, 22, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 19, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9627), new DateTime(2024, 12, 20, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 12, 26, 20, 17, 21, 990, DateTimeKind.Local).AddTicks(9628) });
        }
    }
}
