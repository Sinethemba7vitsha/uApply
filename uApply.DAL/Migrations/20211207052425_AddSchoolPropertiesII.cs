using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class AddSchoolPropertiesII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Schools");

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
    }
}
