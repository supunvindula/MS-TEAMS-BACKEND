using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MS_TEAMS.DataAccess.Migrations
{
    public partial class dummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberTeams",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTeams", x => new { x.TeamId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_MemberTeams_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberTeams_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "email" },
                values: new object[,]
                {
                    { 1, "Supun Vindula", "supunV@99x.io" },
                    { 2, "Indika Rathnasekara", "indikaR@99x.io" },
                    { 3, "Savindu Bandara", "savinduB@99x.io" },
                    { 4, "Shenali Fernando", "shenaliF@99x.io" },
                    { 5, "Chaminda Vithanage", "chamindaV@99x.io" },
                    { 6, "Cassandra Mascarenhas", "cassandraM@99x.io" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Xians" },
                    { 2, "Internal Systems" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, "General", 1 },
                    { 2, "Celebration", 1 },
                    { 3, "Industry Collaborations", 1 },
                    { 4, "Innovatives", 1 },
                    { 5, "Marketing Updates", 1 },
                    { 6, "Technology Updates", 1 },
                    { 9, "Cloud Notifications", 2 },
                    { 8, "Career Developments", 2 },
                    { 7, "General", 2 }
                });

            migrationBuilder.InsertData(
                table: "MemberTeams",
                columns: new[] { "MemberId", "TeamId", "Id" },
                values: new object[,]
                {
                    { 1, 2, 7 },
                    { 6, 1, 6 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 2, 2, 8 },
                    { 2, 1, 2 },
                    { 1, 1, 1 },
                    { 5, 1, 5 },
                    { 3, 2, 9 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "GroupId", "MemberId", "MessageBody", "created" },
                values: new object[,]
                {
                    { 4, 7, 1, "How are you all?", new DateTime(2022, 3, 1, 20, 2, 33, 782, DateTimeKind.Local).AddTicks(6907) },
                    { 5, 7, 2, "Hii", new DateTime(2022, 3, 1, 20, 2, 33, 785, DateTimeKind.Local).AddTicks(6308) },
                    { 6, 7, 3, "There is a power cut today", new DateTime(2022, 3, 1, 20, 2, 33, 785, DateTimeKind.Local).AddTicks(6326) },
                    { 7, 7, 4, "Will See you on other size", new DateTime(2022, 3, 1, 20, 2, 33, 785, DateTimeKind.Local).AddTicks(6329) },
                    { 8, 7, 1, "It is okay Savindu", new DateTime(2022, 3, 1, 20, 2, 33, 785, DateTimeKind.Local).AddTicks(6330) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TeamId",
                table: "Groups",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTeams_MemberId",
                table: "MemberTeams",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId",
                table: "Messages",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MemberId",
                table: "Messages",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberTeams");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
