using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class AddedStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SchoolApplications");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "SchoolApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ApplicationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Not Yet attended" },
                    { 2, "Processing" },
                    { 3, "Admitted" },
                    { 4, "Rejected" }
                });

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "StatusId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 2, 0, 0, 0)), 1 });

            migrationBuilder.InsertData(
                table: "SchoolApplications",
                columns: new[] { "Id", "Created", "GradeId", "LearnerId", "SchoolId", "StatusId" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 2, 2 },
                    { 3, new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3232), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 3, 2 },
                    { 4, new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 2, 0, 0, 0)), 4, 1, 4, 2 },
                    { 5, new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 5, 3 },
                    { 6, new DateTimeOffset(new DateTime(2021, 12, 1, 20, 42, 5, 770, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 2, 0, 0, 0)), 5, 1, 6, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolApplications_StatusId",
                table: "SchoolApplications",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolApplications_ApplicationStatuses_StatusId",
                table: "SchoolApplications",
                column: "StatusId",
                principalTable: "ApplicationStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolApplications_ApplicationStatuses_StatusId",
                table: "SchoolApplications");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropIndex(
                name: "IX_SchoolApplications_StatusId",
                table: "SchoolApplications");

            migrationBuilder.DeleteData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "SchoolApplications");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "SchoolApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Status" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 1, 9, 5, 8, 556, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 2, 0, 0, 0)), "Not Yet Attended" });
        }
    }
}
