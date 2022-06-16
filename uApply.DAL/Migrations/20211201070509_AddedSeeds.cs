using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class AddedSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 9, 5, 8, 556, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmisNumber", "Name" },
                values: new object[] { 896541231L, "Bloemfontein High School" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "EmisNumber", "Name", "SchoolLevelId", "TownId" },
                values: new object[,]
                {
                    { 2, 123456789L, "HTS louis Botha High School", 2, 1 },
                    { 3, 456985213L, "Navalsig High School", 2, 1 },
                    { 4, 6458322544L, "Rose View Primary School", 1, 1 },
                    { 5, 7532156498L, "Castle Bridge Primary School", 1, 1 },
                    { 6, 9632587412L, "Mangaung Primary School", 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2021, 12, 1, 8, 38, 4, 644, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmisNumber", "Name" },
                values: new object[] { 8985785556L, "Bloem High School" });
        }
    }
}
