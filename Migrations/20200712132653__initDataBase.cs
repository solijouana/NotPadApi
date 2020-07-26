using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotePad_api.Migrations
{
    public partial class _initDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    sync = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "CreateDate", "note", "sync", "title" },
                values: new object[] { "1", new DateTime(2020, 7, 12, 17, 56, 53, 219, DateTimeKind.Local).AddTicks(6343), "note sample 1", false, "note 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
