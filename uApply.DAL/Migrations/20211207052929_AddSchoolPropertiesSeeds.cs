using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class AddSchoolPropertiesSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 29, 28, 190, DateTimeKind.Unspecified).AddTicks(7028), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 29, 28, 191, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 29, 28, 191, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 29, 28, 191, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 29, 28, 191, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 29, 28, 191, DateTimeKind.Unspecified).AddTicks(712), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password" },
                values: new object[] { "bloem@gmail.com", "pass123" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { "botha@gmail.com", "pass123" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password" },
                values: new object[] { "navalsig@gmail.com", "pass123" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Password" },
                values: new object[] { "rose@gmail.com", "pass123" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Password" },
                values: new object[] { "castle@gmail.com", "pass123" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Password" },
                values: new object[] { "mangaung@gmail.com", "pass123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 24, 25, 31, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 24, 25, 31, DateTimeKind.Unspecified).AddTicks(4472), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 24, 25, 31, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 24, 25, 31, DateTimeKind.Unspecified).AddTicks(4568), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 24, 25, 31, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 24, 25, 31, DateTimeKind.Unspecified).AddTicks(4647), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Password" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Password" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Password" },
                values: new object[] { null, null });
        }
    }
}
