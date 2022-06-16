using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uApply.DAL.Migrations
{
    public partial class InitialSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Sesotho" },
                    { 3, "isiXhosa" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "South Africa" },
                    { 2, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Free State" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "African" },
                    { 2, "White" }
                });

            migrationBuilder.InsertData(
                table: "SchoolLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Primary School" },
                    { 2, "High School" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mr" },
                    { 2, "Miss" },
                    { 3, "Mrs" },
                    { 4, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 1, "Mangaung", 1 },
                    { 2, "Lejweleputswa", 1 },
                    { 3, "Xhariep", 1 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Name", "SchoolLevelId" },
                values: new object[,]
                {
                    { 1, "8", 2 },
                    { 2, "9", 2 },
                    { 3, "10", 2 },
                    { 4, "11", 2 },
                    { 5, "12", 2 }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bloem" },
                    { 2, 1, "Botshabelo" },
                    { 3, 2, "phuthaditjhaba" },
                    { 4, 2, "betlehem" },
                    { 5, 3, "Frankfort" },
                    { 6, 3, "Ficksburg" }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Email", "FullNames", "GenderId", "IdNumber", "LanguageId", "NationalityId", "Password", "PhoneNumber", "PostalCode", "RaceId", "StreetAddress", "Surburb", "Surname", "TitleId", "TownId", "Username" },
                values: new object[] { 1, "lesetjaofficial26@gmail.com", "lesetja Frans", 1, 3265453088L, 2, 1, "@Sijo4C#", "0636517935", 611, 1, "10360 Poulos Village", "Bakenberg", "Selepe", 1, 1, null });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "EmisNumber", "Name", "SchoolLevelId", "TownId" },
                values: new object[] { 1, 8985785556L, "Bloem High School", 2, 1 });

            migrationBuilder.InsertData(
                table: "Learners",
                columns: new[] { "Id", "Email", "FullNames", "GenderId", "GradeId", "IdNumber", "IsDisabled", "LanguageId", "NationalityId", "ParentId", "Password", "PhoneNumber", "PostalCode", "RaceId", "StreetAddress", "Surburb", "Surname", "TitleId", "TownId", "Username" },
                values: new object[] { 1, "maxvitsha@gmail.com", "Sne Maxwell", 1, 1, 9802356508984L, false, 2, 1, 1, "@Sijo4C#", "0645698789", 611, 1, "10360 Poulos Village", "Bakenberg", "Selepe", 1, 1, null });

            migrationBuilder.InsertData(
                table: "SchoolApplications",
                columns: new[] { "Id", "Created", "GradeId", "LearnerId", "SchoolId", "Status" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 12, 1, 8, 38, 4, 644, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 2, 0, 0, 0)), 1, 1, 1, "Not Yet Attended" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolApplications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Learners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
