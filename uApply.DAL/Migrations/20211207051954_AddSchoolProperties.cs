using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class AddSchoolProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullNames",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullNames",
                table: "Learners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 19, 53, 905, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 19, 53, 905, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 19, 53, 905, DateTimeKind.Unspecified).AddTicks(4326), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 19, 53, 905, DateTimeKind.Unspecified).AddTicks(4351), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 19, 53, 905, DateTimeKind.Unspecified).AddTicks(4375), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 7, 7, 19, 53, 905, DateTimeKind.Unspecified).AddTicks(4501), new TimeSpan(0, 2, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullNames",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullNames",
                table: "Learners",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3232), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
