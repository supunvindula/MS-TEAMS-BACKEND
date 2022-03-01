using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MS_TEAMS.DataAccess.Migrations
{
    public partial class seedDataV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "MessageBody", "created" },
                values: new object[] { 4, "How are you all?", new DateTime(2022, 3, 1, 10, 44, 13, 707, DateTimeKind.Local).AddTicks(7717) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
