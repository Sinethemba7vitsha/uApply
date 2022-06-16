using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class UpdateTown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 12, 28, 7, 408, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 12, 28, 7, 408, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 12, 28, 7, 408, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 12, 28, 7, 408, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 12, 28, 7, 408, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 12, 28, 7, 408, DateTimeKind.Unspecified).AddTicks(8943), new TimeSpan(0, 2, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
