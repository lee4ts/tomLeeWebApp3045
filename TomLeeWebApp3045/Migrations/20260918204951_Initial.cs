using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TomLeeWebApp3045.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserLib",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLib", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserLib",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Uncategorized", new DateTime(2026, 9, 18, 16, 49, 51, 25, DateTimeKind.Local).AddTicks(400), "Welcome to the BLib!", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1720) },
                    { 2, "Science Fiction", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1830), "The Time Machine", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1830) },
                    { 3, "History", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840), "Narrative of the Life of Frederick Douglass", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840) },
                    { 4, "Technology", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840), "Color Images from Mars Rovers", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840) },
                    { 5, "Art", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840), "The Notebooks of Leonardo da Vinci", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840) },
                    { 6, "Literature", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840), "Moby Dick", new DateTime(2026, 9, 18, 16, 49, 51, 28, DateTimeKind.Local).AddTicks(1840) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLib");
        }
    }
}
