using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MS_TEAMS.DataAccess.Migrations
{
    public partial class dummyDataV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MessageBody",
                table: "Messages",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "created",
                value: new DateTime(2022, 3, 2, 23, 11, 23, 91, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "created",
                value: new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "created",
                value: new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "created",
                value: new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "created",
                value: new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "GroupId", "MemberId", "MessageBody", "created" },
                values: new object[] { 9, 8, 1, "Hello Career Developments", new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1223) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "MessageBody",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "created",
                value: new DateTime(2022, 3, 2, 14, 43, 12, 921, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "created",
                value: new DateTime(2022, 3, 2, 14, 43, 12, 924, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "created",
                value: new DateTime(2022, 3, 2, 14, 43, 12, 924, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "created",
                value: new DateTime(2022, 3, 2, 14, 43, 12, 924, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "created",
                value: new DateTime(2022, 3, 2, 14, 43, 12, 924, DateTimeKind.Local).AddTicks(3771));
        }
    }
}
