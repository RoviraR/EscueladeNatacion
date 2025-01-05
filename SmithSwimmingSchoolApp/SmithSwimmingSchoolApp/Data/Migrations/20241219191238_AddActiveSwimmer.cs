using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmithSwimmingSchoolApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddActiveSwimmer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "Swimmers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 8, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 12, 9, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 13, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 12, 14, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 10, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 12, 11, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 16, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 12, 17, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 18, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 12, 19, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 12, 22, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 19, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3615), new DateTime(2024, 12, 20, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3618), new DateTime(2024, 12, 26, 20, 12, 37, 777, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 1,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 2,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 3,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 4,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 5,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 6,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 7,
                column: "Inactive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "SwimmerId",
                keyValue: 8,
                column: "Inactive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "Swimmers");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 8, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7130), new DateTime(2024, 12, 9, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 13, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 12, 14, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 10, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 12, 11, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 16, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 12, 17, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 18, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 12, 19, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 21, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 12, 22, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 19, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 12, 20, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 25, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 12, 26, 19, 57, 20, 561, DateTimeKind.Local).AddTicks(7155) });
        }
    }
}
