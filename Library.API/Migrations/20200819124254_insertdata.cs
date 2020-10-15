using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.API.Migrations
{
    public partial class insertdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthData",
                table: "Authors",
                newName: "BirthDate");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a3330"), new DateTimeOffset(new DateTime(1960, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "广东广州", "authorl@xxx.com", "Author1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a3330"));

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Authors",
                newName: "BirthData");
        }
    }
}
