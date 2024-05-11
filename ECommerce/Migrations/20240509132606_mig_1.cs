using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5890), "Electronics", new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5920) },
                    { 2, new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930), "Stationary", new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930) },
                    { 3, new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930), "Sport", new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category_Id", "Cost", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 20f, new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890), "Nokia Phone", new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890) },
                    { 2, 1, 2130f, new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890), "Pentium 1203", new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890) },
                    { 3, 3, 43f, new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890), "GoalKeeper Gloves", new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7900) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id",
                table: "Products",
                column: "Category_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
