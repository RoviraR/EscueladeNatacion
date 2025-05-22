using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmithSwimmingSchoolApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDateReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Reports",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Reports");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 8, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1176), new DateTime(2024, 12, 9, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 13, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 12, 14, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1183), new DateTime(2024, 12, 11, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 12, 17, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 18, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1190), new DateTime(2024, 12, 19, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1194), new DateTime(2024, 12, 22, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 19, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1197), new DateTime(2024, 12, 20, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8,
                columns: new[] { "End_Date", "Start_Date" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 12, 26, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1199) });
        }
    }
}
